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
            //Verifie si il existe une evaluation de ce rh pour cette candid et offre
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(id_evaluation) FROM EVALUATION WHERE EVALUATION.nom_rh_evaluation = '" + nom_rh + "' AND EVALUATION.prenom_rh_evaluation = '" + prenom_rh + "' AND id_candidature = (SELECT id_candidature FROM CANDIDATURE WHERE id_offre_emplois = " + offre + " AND nom_candidature = '" + nom_candid + "' AND prenom_candidature = '" + prenom_candid + "'); ", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    eval = reader.GetInt32(0);
                }
            }

            //Créer une evaluation si elle existe pas déjà
            if (eval == 0)
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO EVALUATION(nom_rh_evaluation, prenom_rh_evaluation, bonus_malus_evaluation, commentaire_evaluation, id_candidature) VALUES('" + nom_rh + "','" + prenom_rh + "',0,'',(SELECT id_candidature FROM CANDIDATURE WHERE CANDIDATURE.nom_candidature ='" + nom_candid + "' AND CANDIDATURE.prenom_candidature ='" + prenom_candid + "' AND CANDIDATURE.id_offre_emplois=" + offre + "));", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            //Recupere l'id de l'evaluation
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id_evaluation FROM EVALUATION INNER JOIN CANDIDATURE ON CANDIDATURE.id_candidature = EVALUATION.id_evaluation WHERE CANDIDATURE.nom_candidature ='" + nom_candid + "' AND CANDIDATURE.prenom_candidature ='" + prenom_candid + "' AND CANDIDATURE.id_offre_emplois=" + offre + " AND EVALUATION.nom_rh_evaluation = '" + nom_candid + "' AND EVALUATION.prenom_rh_evaluation = '" + prenom_candid + "' ;", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    eval = reader.GetInt32(0);
                }
            }

            int verifnote = -1;
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(NOTER.note) FROM NOTER WHERE NOTER.id_evaluation = " + eval + " AND id_critere = (SELECT CRITERE.id_critere FROM CRITERE WHERE CRITERE.libelle_critere = '" + libelle_crit + "');", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    verifnote = reader.GetInt32(0);
                }
            }

            if (verifnote == 1)
            {

            }
            else
            {
                //Créer la note pour un critere
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO NOTER(note, id_evaluation, id_critere) VALUES(" + note + ", (SELECT EVALUATION.id_evaluation FROM EVALUATION JOIN CANDIDATURE ON CANDIDATURE.id_candidature = EVALUATION.id_evaluation WHERE CANDIDATURE.nom_candidature = '" + nom_candid + "' AND CANDIDATURE.prenom_candidature = '" + prenom_candid + "' AND CANDIDATURE.id_offre_emplois = 1 AND EVALUATION.nom_rh_evaluation = '" + nom_rh + "' AND EVALUATION.prenom_rh_evaluation = '" + prenom_rh + "'),(SELECT CRITERE.id_critere FROM CRITERE INNER JOIN ASSOCIER ON ASSOCIER.id_critere = CRITERE.id_critere WHERE ASSOCIER.id_offre_emplois = 1 AND CRITERE.libelle_critere = '" + libelle_crit + "'  ));", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
