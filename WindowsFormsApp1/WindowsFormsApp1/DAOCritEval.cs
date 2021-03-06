﻿using System;
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
            //Recupere l'id de l'evaluation
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id_evaluation FROM EVALUATION WHERE EVALUATION.nom_rh_evaluation = '" + nom_rh + "' AND EVALUATION.prenom_rh_evaluation = '" + prenom_rh + "' AND id_candidature = (SELECT id_candidature FROM CANDIDATURE WHERE id_offre_emplois = " + offre + " AND nom_candidature = '" + nom_candid + "' AND prenom_candidature = '" + prenom_candid + "');", conn))
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
                //Met à jour la note du critere
                using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE NOTER SET note = " + note + " WHERE id_evaluation = (SELECT EVALUATION.id_evaluation FROM EVALUATION INNER JOIN CANDIDATURE ON CANDIDATURE.id_candidature = EVALUATION.id_candidature WHERE CANDIDATURE.nom_candidature = '" + nom_candid + "' AND CANDIDATURE.prenom_candidature = '" + prenom_candid + "' AND CANDIDATURE.id_offre_emplois = " + offre + " AND EVALUATION.nom_rh_evaluation = '" + nom_rh + "' AND EVALUATION.prenom_rh_evaluation = '" + prenom_rh + "') AND id_critere = (SELECT CRITERE.id_critere FROM CRITERE INNER JOIN ASSOCIER ON ASSOCIER.id_critere = CRITERE.id_critere WHERE ASSOCIER.id_offre_emplois = " + offre + " AND CRITERE.libelle_critere = '" + libelle_crit + "'  );", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                //Créer la note pour un critere
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO NOTER(note, id_evaluation, id_critere) VALUES(" + note + ", " + eval + ",(SELECT CRITERE.id_critere FROM CRITERE INNER JOIN ASSOCIER ON ASSOCIER.id_critere = CRITERE.id_critere WHERE ASSOCIER.id_offre_emplois = 1 AND CRITERE.libelle_critere = '" + libelle_crit + "'  ));", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public static int GetNombreNoteByOffreNomPrenomRHNomPrenomCandid(NpgsqlConnection conn, int offre, string nom_candid, string prenom_candid, string nom_rh, string prenom_rh)
        {
            int resul = -1;
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(note) FROM NOTER WHERE id_evaluation = (SELECT id_evaluation FROM EVALUATION INNER JOIN CANDIDATURE ON CANDIDATURE.id_candidature = EVALUATION.id_candidature WHERE CANDIDATURE.nom_candidature = '" + nom_candid + "' AND CANDIDATURE.prenom_candidature = '" + prenom_candid + "' AND EVALUATION.prenom_rh_evaluation = '" + prenom_rh + "' AND EVALUATION.nom_rh_evaluation = '" + nom_rh + "' AND CANDIDATURE.id_offre_emplois = " + offre + ");", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    resul = reader.GetInt32(0);
                }
            }
            return resul;
        }
    }
}
