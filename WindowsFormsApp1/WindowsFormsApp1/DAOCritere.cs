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

                using (var cmd = new NpgsqlCommand("SELECT CRITERE.id_critere, CRITERE.libelle_critere FROM CRITERE ;", conn))
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

        /// <summary>
        /// Methode qui permet d'obtenir un critere et son coef associé selon l'offre mise en parametre
        /// </summary>
        /// <param name="offre"></param>
        /// <returns></returns>
        public static Dictionary<int,Critere> GetCritereCoefByOffre(int offre)
        {
            Dictionary<int,Critere> resul = new Dictionary<int, Critere>();

            var connString = "Host=localhost;Port=8484;Username=openpg;Password=;Database=AppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT CRITERE.id_critere, CRITERE.libelle_critere ASSOCIER.coef FROM CRITERE INNER JOIN ASSOCIER ON ASSOCIER.id_crietre = CRITERE.id_crietre WHERE ASSOCIER.id_offre_emplois =" + offre + ";", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Critere c = new Critere(int.Parse(reader.GetString(0)), reader.GetString(1));
                        resul.Add(reader.GetInt32(3),c);
                    }
                }
            }

            return resul;
        }
    }
}
