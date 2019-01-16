using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1
{
    public class DAOCandidature
    {
        public static List<Candidature> GetCandidatureByOffre(NpgsqlConnection conn, int offre)
        {
            List<Candidature> resul = new List<Candidature>();
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT CANDIDATURE.id_candidature, CANDIDATURE.nom_candidature, CANDIDATURE.prenom_candidature, CANDIDATURE.date_candidature, CANDIDATURE.statut_candidature FROM CANDIDATURE WHERE CANDIDATURE.id_offre_emplois=" + offre + " ;", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Candidature c = new Candidature(reader.GetInt32(0),reader.GetString(1), reader.GetString(2),reader.GetDateTime(3),reader.GetString(4));
                    resul.Add(c);
                }
            }

            return resul;
        }
    }
}
