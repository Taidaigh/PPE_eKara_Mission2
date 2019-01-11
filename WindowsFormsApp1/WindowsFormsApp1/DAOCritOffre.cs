using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1
{
    public class DAOCritOffre
    {

        /// <summary>
        /// Methode qui permet de recuperer les coef
        /// </summary>
        /// <param name="offre"></param>
        /// <returns></returns>
        public static List<CritOffre> GetCritOffre(int offre)
        {
            List<CritOffre> resul = new List<CritOffre>();

            var connString = "Host=localhost;Port=8484;Username=openpg;Password=;Database=AppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT ASSOCIER.coef FROM ASSOCIER WHERE id_offre_emplois = "+ offre +";", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CritOffre c = new CritOffre(int.Parse(reader.GetString(0)), int.Parse(reader.GetString(1)), reader.GetString(2));
                        resul.Add(c);
                    }
                }
            }

            return resul;
        }
    }
}
