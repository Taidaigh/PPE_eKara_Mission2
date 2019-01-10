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
        public static void Connexion()
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=postgres";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
            }
    }

    }
}
