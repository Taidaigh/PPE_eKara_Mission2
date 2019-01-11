﻿using System;
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
        public static List<Offre> GetOffre()
        {
            List<Offre> resul = new List<Offre>();
            var connString = "Host=localhost;Port=5432;Username=postgres;Password=test;Database=AppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT OFFRE_EMPLOIS.id_offre_emplois, OFFRE_EMPLOIS.intitule_offre_emplois, OFFRE_EMPLOIS.lieux_offre_emplois, OFFRE_EMPLOIS.date_limite_offre FROM OFFRE_EMPLOIS", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Offre o = new Offre(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3),reader.GetDateTime(4));
                        resul.Add(o);
                    }
                }
            }
            return resul;
        }



    }
}
