using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1
{
    public class DAOCritEval
    {
		public static void SetNote(NpgsqlConnection conn, int offre, string nom_candid, string prenom_candid,int note,string nom_rh, string prenom_rh, string libelle_crit)
        {
            int eval = -1;
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(id_evaluation) FROM EVALUATION INNER JOIN CANDIDATURE ON CANDIDATURE.id_candidature = EVALUATION.id_evaluation WHERE CANDIDATURE.nom_candidature ='" + nom_candid + "' AND CANDIDATURE.prenom_candidature ='" + prenom_candid + "' AND CANDIDATURE.id_offre_emplois=" + offre + " AND EVALUATION.nom_rh_evaluation = '"+nom_candid+ "' AND EVALUATION.prenom_rh_evaluation = '" + prenom_candid + "' ;", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    eval = reader.GetInt32(0);
                }
            }

            if (eval == 0)
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO EVALUATION(nom_rh_evaluation, prenom_rh_evaluation, bonus_malus_evaluation, commentaire_evaluation, id_candidature) VALUES('" + nom_rh + "','" + prenom_rh + "',0,'',(SELECT id_candidature FROM CANDIDATURE WHERE CANDIDATURE.nom_candidature ='" + nom_candid + "' AND CANDIDATURE.prenom_candidature ='" + prenom_candid + "' AND CANDIDATURE.id_offre_emplois=" + offre + "));", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id_evaluation FROM EVALUATION INNER JOIN CANDIDATURE ON CANDIDATURE.id_candidature = EVALUATION.id_evaluation WHERE CANDIDATURE.nom_candidature ='" + nom_candid + "' AND CANDIDATURE.prenom_candidature ='" + prenom_candid + "' AND CANDIDATURE.id_offre_emplois=" + offre + " AND EVALUATION.nom_rh_evaluation = '" + nom_candid + "' AND EVALUATION.prenom_rh_evaluation = '" + prenom_candid + "' ;", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    eval = reader.GetInt32(0);
                }
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO NOTER(note, id_evaluation, id_critere) VALUES("+note+ ",(SELECT id_evaluation FROM EVALUATION INNER JOIN CANDIDATURE ON CANDIDATURE.id_candidature = EVALUATION.id_evaluation WHERE CANDIDATURE.nom_candidature ='" + nom_candid + "' AND CANDIDATURE.prenom_candidature ='" + prenom_candid + "' AND CANDIDATURE.id_offre_emplois=" + offre + " AND EVALUATION.nom_rh_evaluation = '" + nom_candid + "' AND EVALUATION.prenom_rh_evaluation = '" + prenom_candid + "'),(SELECT CRITIQUE.libelle_crit FROM CRITIQUE INNER JOIN ASSOCIER ON ASSOCIER.id_critere = CRITIQUE.id_critere WHERE ASSOCIER.id_offre_emplois = "+offre+" AND CRITERE.libelle_critere = "+libelle_crit+"  );", conn))
            {
                cmd.ExecuteNonQuery();
            }

        }
    }
}
