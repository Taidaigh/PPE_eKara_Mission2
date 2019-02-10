using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1
{
    public class DAOOffre
    {
        /// <summary>
        /// Methode qui permet d'acceder à la base de donnée et de recuperer toutes les offres d'emplois
        /// </summary>
        /// <returns></returns>
        public static List<Offre> GetOffre(NpgsqlConnection conn)
        {
            List<Offre> resul = new List<Offre>();

            using (var cmd = new NpgsqlCommand("SELECT OFFRE_EMPLOIS.id_offre_emplois, OFFRE_EMPLOIS.intitule_offre_emplois, OFFRE_EMPLOIS.lieux_offre_emplois,OFFRE_EMPLOIS.salaire_offre_emplois, OFFRE_EMPLOIS.date_limite_offre_emplois FROM OFFRE_EMPLOIS ORDER BY  OFFRE_EMPLOIS.id_offre_emplois;", conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Offre o = new Offre(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3),reader.GetDateTime(4));
                    resul.Add(o);
                }
            }
            return resul;
        }

        public static Offre GetOffreById(NpgsqlConnection conn, int id_offre)
        {
            Offre resul = null;

            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT OFFRE_EMPLOIS.id_offre_emplois, OFFRE_EMPLOIS.intitule_offre_emplois, OFFRE_EMPLOIS.lieux_offre_emplois,OFFRE_EMPLOIS.salaire_offre_emplois, OFFRE_EMPLOIS.date_limite_offre_emplois FROM OFFRE_EMPLOIS WHERE OFFRE_EMPLOIS.id_offre_emplois = " + id_offre + " ORDER BY  OFFRE_EMPLOIS.id_offre_emplois ;", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    resul = new Offre(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDateTime(4));
                }
            }
            return resul;
        }

        public static void SetDateLimite(NpgsqlConnection conn, int id_offre, DateTime dateLimite)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE OFFRE_EMPLOIS SET date_limite_offre_emplois = '" + dateLimite + "' WHERE id_offre_emplois = " + id_offre + ";", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public static void VerrouillerOffre(NpgsqlConnection conn, int id_offre)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand("", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
