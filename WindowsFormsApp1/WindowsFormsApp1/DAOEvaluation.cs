using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1
{
    public class DAOEvaluation
    {
        public static Evaluation GetEvalByOffreNomPrenomCandidNomPrenomRH(NpgsqlConnection conn, int offre, string nom_candid, string prenom_candid, string nom_rh, string prenom_rh)
        {
            Evaluation resul;
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT EVALUATION.id_evaluation, EVALUATION.nom_rh_evaluation,EVALUATION.prenom_rh_evaluation, EVALUATION.bonus_malus_evaluation, EVALUATION.commentaire_evaluation FROM EVALUATION WHERE EVALUATION.id_candidature = (SELECT id_candidature FROM CANDIDATURE WHERE CANDIDATURE.id_offre_emplois = " + offre+ " AND CANDIDATURE.nom_candidature = '" + nom_candid + "' AND CANDIDATURE.prenom_candidature ='" + prenom_candid + "') AND nom_rh_evaluation = '" + nom_rh + "' AND prenom_rh_evaluation = '" + prenom_rh+"';", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                resul = new Evaluation(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                
            }

            return resul;
        }

        public static void SetBonusMalusComs(NpgsqlConnection conn, int offre, string nom_candid, string prenom_candid, string nom_rh, string prenom_rh, int bonusMalus, string commentaire)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE EVALUATION SET bonus_malus_evaluation = " + bonusMalus + " WHERE EVALUATION.id_candidature = (SELECT id_candidature FROM CANDIDATURE WHERE CANDIDATURE.id_offre_emplois = " + offre + " AND CANDIDATURE.nom_candidature = '" + nom_candid + "' AND CANDIDATURE.prenom_candidature ='" + prenom_candid + "') AND nom_rh_evaluation = '" + nom_rh + "' AND prenom_rh_evaluation = '" + prenom_rh + "';", conn))
            {
                cmd.ExecuteNonQuery();
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE EVALUATION SET commentaire_evaluation = '" + commentaire + "' WHERE EVALUATION.id_candidature = (SELECT id_candidature FROM CANDIDATURE WHERE CANDIDATURE.id_offre_emplois = " + offre + " AND CANDIDATURE.nom_candidature = '" + nom_candid + "' AND CANDIDATURE.prenom_candidature ='" + prenom_candid + "') AND nom_rh_evaluation = '" + nom_rh + "' AND prenom_rh_evaluation = '" + prenom_rh + "';", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
