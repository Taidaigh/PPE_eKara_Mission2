using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1
{
    public class Connexion
    {

        public static NpgsqlConnection Connect()
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=;Database=AppEval";

            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();

            return conn;
        }

        public static void Deconnect(NpgsqlConnection conn)
        {
            conn.Close();
        }
    }
}
