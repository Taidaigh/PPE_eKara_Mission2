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
        public static List<string> GetOffre()
        {
            List<string> resul = new List<string>();
            var connString = "Host=localhost;Port=5432;Username=postgres;Password=test;Database=AppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT intitule_offre_emplois FROM OFFRE_EMPLOIS", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resul.Add(reader.GetString(0));
                    }
                }
            }
            return resul;
        }



    }
}
