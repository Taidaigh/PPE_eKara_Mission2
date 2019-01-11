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
        /// <param name="offre"></param>
        /// <returns></returns>
        public static List<Critere> GetCritere(int offre)
        {
            List<Critere> resul = new List<Critere>();

            var connString = "Host=localhost;Port=8484;Username=openpg;Password=;Database=AppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT CRITERE.id_critere CRITERE.libelle_critere FROM CRITERE ;", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Critere c = new Critere(int.Parse(reader.GetString(0)), reader.GetString(1));
                        resul.Add(c);
                    }
                }
            }

            return resul;
        }
    }
}
