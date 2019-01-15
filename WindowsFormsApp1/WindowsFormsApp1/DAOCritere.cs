using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace WindowsFormsApp1
{
    public class DAOCritere
    {
        /// <summary>
        /// Methode qui permet de recuperer les criteres
        /// </summary>
        /// <returns></returns>
        public static List<Critere> GetCritere(NpgsqlConnection conn)
        {
            List<Critere> resul = new List<Critere>();

            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT CRITERE.id_critere, CRITERE.libelle_critere FROM CRITERE ORDER BY CRITERE.id_critere;", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Critere c = new Critere(reader.GetInt32(0), reader.GetString(1));
                    resul.Add(c);
                }
            }

            return resul;
        }

        /// <summary>
        /// Methode qui permet d'obtenir un critere et son coef associé selon l'offre mise en parametre
        /// </summary>
        /// <param name="offre"></param>
        /// <returns></returns>
        public static Dictionary<Critere,double> GetCritereCoefByOffre(NpgsqlConnection conn,int offre)
        {
            Dictionary<Critere,double> resul = new Dictionary<Critere,double>();
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT CRITERE.id_critere, CRITERE.libelle_critere, ASSOCIER.coef FROM CRITERE INNER JOIN ASSOCIER ON ASSOCIER.id_critere = CRITERE.id_critere WHERE ASSOCIER.id_offre_emplois = " + offre + "ORDER BY CRITERE.id_critere;", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Critere c = new Critere(int.Parse(reader.GetInt32(0).ToString()), reader.GetString(1));
                    resul.Add(c, reader.GetDouble(2));
                }
            }           
            
            return resul;
        }

        /// <summary>
        /// Methode qui permet d'ajouter des critères
        /// </summary>
        /// <returns></returns>
        public static void AddCrit(NpgsqlConnection conn,string libelle, double coef, int id_offre)
        {
            Boolean verif = true;
            foreach (Critere c in DAOCritere.GetCritere(conn))
            {
                if(c.Libelle == libelle)
                {
                    verif = false;
                }
            }
            if (verif == true)
            {
                //Créer un Critère
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO CRITERE(libelle_critere) VALUES('" + libelle + "' ); INSERT INTO ASSOCIER(coef, id_critere,id_offre_emplois) VALUES(" + coef + ",(SELECT currval('CRITERE_id_critere_seq'))," + id_offre + ");", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                using (NpgsqlCommand cmd2 = new NpgsqlCommand("INSERT INTO ASSOCIER(coef, id_critere,id_offre_emplois) VALUES(" + coef + ",(SELECT CRITERE.id_critere FROM CRITERE WHERE libelle_critere='" + libelle + "')," + id_offre + ");", conn))
                {
                    cmd2.ExecuteNonQuery();
                }

            }


            //Recupere un serial fonction curval


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conn"></param>
        public static void ModifCrit(NpgsqlConnection conn, string libelle, double coef, int id_offre)
        {
            int id_critere = -1;
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT CRITERE.id_critere FROM CRITERE WHERE CRITERE.libelle_critere = "+ libelle +";", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id_critere = reader.GetInt32(0);
                }
            }

            NpgsqlCommand cmd2 = new NpgsqlCommand("UPDATE ASSOCIER SET coef = " + coef + " WHERE id_critere = " + id_critere + " AND id_offre_emplois = " + id_offre + "", conn);
            cmd2.ExecuteNonQuery();
        }


        public static void DelCrit(NpgsqlConnection conn, string libelle, int id_offre)
        {
            int id_critere = -1;
            //On recupere l'id du critere à supprimer
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT CRITERE.id_critere FROM CRITERE WHERE CRITERE.libelle_critere = " + libelle + ";", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id_critere = reader.GetInt32(0);
                }
            }

            int association = 0;
            //On verifie si il y a une ou plusieurs Offre associer à ce critere
            using (NpgsqlCommand cmd2 = new NpgsqlCommand("SELECT COUNT(ASSOCIER.coef) FROM ASSOCIER WHERE CRITERE.id_critere = " + id_critere + ";", conn))
            using (NpgsqlDataReader reader2 = cmd2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    association = reader2.GetInt32(0);
                }
            }

            //Suppression de l'association
            NpgsqlCommand cmd3 = new NpgsqlCommand("DELETE FROM ASSOCIER WHERE CRITERE.id_critere = " + id_critere + " AND OFFRE.id_offre_emplois = " + id_offre + ";", conn);
            cmd3.ExecuteNonQuery();

            //Si il y avait plus que cette association on supprime le critère
            if (association == 1)
            {
                NpgsqlCommand cmd4 = new NpgsqlCommand("DELETE FROM CRITERE WHERE CRITERE.id_critere = " + id_critere + ";", conn);
                cmd4.ExecuteNonQuery();
            }

        }
    }
}
