using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data;
using System.Threading.Tasks;
using Npgsql;
//using NpgsqlTypes;

namespace WindowsFormsApp1
{
    public static class Passerelle
    {
        //Connexion bdd TEST
        public static void Connexion()
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=postgres";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
            }
        }

        public static List<string> AfficheOffre()
        {
            List<string> resul = new List<string>();
            var connString = "Host=localhost;Port=5432;Username=postgres;Password=test;Database=AppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT intitule_offre_emplois FROM OFFRE_EMPLOIS", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        resul.Add(reader.GetString(0));
                    }
                }
            }
            return resul;

        }

        /// <summary>
        /// Methode qui permet de recuperer les criteres de l'offre mise en parametre
        /// </summary>
        /// <param name="offre"></param>
        /// <returns></returns>
        public static Dictionary<int,string> AfficheCritereOffre(int offre)
        {
            Dictionary<int, string> resul = new Dictionary<int, string>();

            var connString = "Host=localhost;Port=8484;Username=openpg;Password=;Database=AppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT CRITERE.libelle_critere, ASSOCIER.coef FROM CRITERE INNER JOIN ASSOCIER ON ASSOCIER.id_critere = CRITERE.id_critere WHERE ASSOCIER.id_offre_emplois=" + offre + ";", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resul.Add(int.Parse(reader.GetString(0)), reader.GetString(1));
                    }
                }
            }

            return resul;
        }
    }
}
