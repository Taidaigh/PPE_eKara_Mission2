using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

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

            using (var cmd = new NpgsqlCommand("SELECT CRITERE.id_critere, CRITERE.libelle_critere FROM CRITERE ;", conn))
            using (var reader = cmd.ExecuteReader())
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
        public static Dictionary<double,Critere> GetCritereCoefByOffre(NpgsqlConnection conn,int offre)
        {
            Dictionary<double,Critere> resul = new Dictionary<double, Critere>();
            using (var cmd = new NpgsqlCommand("SELECT CRITERE.id_critere, CRITERE.libelle_critere, ASSOCIER.coef FROM CRITERE INNER JOIN ASSOCIER ON ASSOCIER.id_critere = CRITERE.id_critere WHERE ASSOCIER.id_offre_emplois = " + offre + ";", conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Critere c = new Critere(int.Parse(reader.GetInt32(0).ToString()), reader.GetString(1));
                    resul.Add(reader.GetDouble(2),c);
                }
            }
            
            return resul;
        }

        /// <summary>
        /// Methode qui permet d'ajouter des critères
        /// </summary>
        /// <returns></returns>
        public static void AddCrit(NpgsqlConnection conn,string libelle, int coef, int id_offre)
        {
            using (var cmd = new NpgsqlCommand("INSERT INTO CRITERE VALUES(," + libelle + " );", conn))
            //Recupere un serial fonction curval
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Critere c = new Critere(int.Parse(reader.GetString(0)), reader.GetString(1));
                    //resul.Add(c);
                }
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conn"></param>
        public static void ModifCrit(NpgsqlConnection conn)
        {
            using (var cmd = new NpgsqlCommand("", conn))
            //Recupere un serial fonction curval
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Critere c = new Critere(int.Parse(reader.GetString(0)), reader.GetString(1));
                    //resul.Add(c);
                }
            }
        }
    }
}
