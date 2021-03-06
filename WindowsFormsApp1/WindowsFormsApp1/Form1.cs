﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using WindowsFormsApp1.ServiceReference1;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Déclaration des variables
        NpgsqlConnection conn;

        //Gestion des DRH
        Boolean drh = true;
        string rhNom = "De Lemos Almeida";
        string rhPrenom = "Pierre";

        /// <summary>
        /// Création du form
        /// </summary>
        public Form1()
        {
            //Initiation des composants
            InitializeComponent();

            //Connexion bdd
            conn = Connexion.Connect();


            //Synchroniser
            sioservicePortClient webClient = new sioservicePortClient();
            int resul = 0;
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id_offre_emplois FROM OFFRE_EMPLOIS", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    resul = reader.GetInt32(0);
                }
            }

            string xmlOffre = webClient.exportOffre(resul.ToString());
            XmlDocument doc1 = new XmlDocument();
            doc1.LoadXml(xmlOffre);

            XmlNodeList elemID = doc1.GetElementsByTagName("id");
            XmlNodeList elemIntitule = doc1.GetElementsByTagName("intitule");
            XmlNodeList elemLieux = doc1.GetElementsByTagName("lieux");
            XmlNodeList elemSalaire = doc1.GetElementsByTagName("salaire");

            for (int i = 0; i < elemID.Count; i++)
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO OFFRE_EMPLOIS(id_offre_emplois,intitule_offre_emplois,lieux_offre_emplois,salaire_offre_emplois,date_limite_offre_emplois,verrouiller_offre_emplois) VALUES(" + elemID[i].InnerXml + ",'" + elemIntitule[i].InnerXml + "','" + elemLieux[i].InnerXml + "'," + elemSalaire[i].InnerXml + ", NOW(), false);", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }


            string xmlCandid = webClient.exportCandid(resul.ToString());
            XmlDocument doc2 = new XmlDocument();
            doc1.LoadXml(xmlCandid);

            XmlNodeList elemIdCandid = doc2.GetElementsByTagName("id_candid");
            XmlNodeList elemNom = doc2.GetElementsByTagName("nom");
            XmlNodeList elemPrenom = doc2.GetElementsByTagName("prenom");
            XmlNodeList elemId_emplois = doc2.GetElementsByTagName("id_emplois");

            for (int i = 0; i < elemID.Count; i++)
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO CANDIDATURE(id_candidature, nom_candidature, prenom_candidature, date_candidature, statut_candidature, id_offre_emplois) VALUES(" + elemId_emplois[i].InnerXml + ", '" + elemNom[i].InnerXml + "', '" + elemPrenom[i].InnerXml + "', NOW(), 'attente', " + elemId_emplois[i].InnerXml + ");", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }


            //Gere les differents modes des onglets
            if (this.drh == true)
            {
                tabCtrl.TabPages.Clear();
                tabCtrl.TabPages.Add(tabOff);
                tabCtrl.TabPages.Add(tabReu);
                //Generation de la liste des offres
                foreach (Offre o in DAOOffre.GetOffre(conn))
                {
                    lstOffre.Items.Add(o.Intitule);
                    lstOffreId.Items.Add(o.Id);
                }
            }
            else
            {
                tabCtrl.TabPages.Clear();
                tabCtrl.TabPages.Add(tabNot);
                //Generation de la liste des offres
                foreach (Offre o in DAOOffre.GetOffreWhereDateVerr(conn))
                {
                    lstOffreNoter.Items.Add(o.Intitule);
                    lstOffreNoterId.Items.Add(o.Id);
                }

                lstCandid.Enabled = false;
                dataGridViewCritNote.Enabled = false;
                gpBoxEval.Enabled = false;
            }
        }


        //Event sur la liste d'offre lors d'un changement de selection d'index
        private void lstOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DAOOffre.GetVerrouilleById(conn, int.Parse(lstOffreId.Items[lstOffre.SelectedIndex].ToString())) == false)
            {
                btnVerr.Enabled = true;
                dataGridViewCrit.Enabled = true;
                btnReu.Enabled = false;
                gpBoxAdd.Enabled = true;
                gpBoxDateLimite.Enabled = true;
            }
            else
            {
                btnVerr.Enabled = false;
                dataGridViewCrit.Enabled = false;
                btnReu.Enabled = true;
                gpBoxAdd.Enabled = false;
                gpBoxDateLimite.Enabled = false;
            }
            //Reinitialise la liste des criteres
            dataGridViewCrit.Rows.Clear();
            //Ajout des criteres de l'offre dans la liste de critère
            Boolean first = true;
            foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(conn, int.Parse(lstOffreId.Items[lstOffre.SelectedIndex].ToString())))
            {
                if (first == true)
                {
                    first = false;
                    dataGridViewCrit.Rows[0].Cells[0].Value = o.Key.Libelle;
                    dataGridViewCrit.Rows[0].Cells[1].Value = o.Value;
                }
                else
                {
                    dataGridViewCrit.Rows.Add(o.Key.Libelle, o.Value);
                }
            }
            //Afficher la date limite            
            dateTimePicker.Value = DAOOffre.GetOffreById(conn, int.Parse(lstOffreId.Items[lstOffre.SelectedIndex].ToString())).DateLimite;

            comboBoxCritAdd.Items.Clear();
            foreach (Critere c in DAOCritere.GetCritere(conn))
            {
                comboBoxCritAdd.Items.Add(c.Libelle);
            }
        }


        private void btnAddCrit_Click(object sender, EventArgs e)
        {
            DAOCritere.AddCrit(conn, comboBoxCritAdd.Text, double.Parse(txtBoxCritCoefAdd.Text), int.Parse(lstOffreId.Items[lstOffre.SelectedIndex].ToString()));

            //Reinitialise la liste des criteres
            dataGridViewCrit.Rows.Clear();
            //Ajout des criteres de l'offre dans la liste de critère
            Boolean first = true;
            foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(conn, int.Parse(lstOffreId.Items[lstOffre.SelectedIndex].ToString())))
            {
                if (first == true)
                {
                    first = false;
                    dataGridViewCrit.Rows[0].Cells[0].Value = o.Key.Libelle;
                    dataGridViewCrit.Rows[0].Cells[1].Value = o.Value;
                }
                else
                {
                    dataGridViewCrit.Rows.Add(o.Key.Libelle, o.Value);
                }
            }

            //Afficher la date
            dateTimePicker.Value = DAOOffre.GetOffreById(conn, int.Parse(lstOffreId.Items[lstOffre.SelectedIndex].ToString())).DateLimite;            
        }

        //Deconnexion de la bdd lors de la fermeture du form
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Connexion.Deconnect(conn);
        }

        private void btnDateLimite_Click(object sender, EventArgs e)
        {
            DAOOffre.SetDateLimite(conn, int.Parse(lstOffreId.Items[lstOffre.SelectedIndex].ToString()), dateTimePicker.Value);
            dateTimePicker.Value = DAOOffre.GetOffreById(conn, int.Parse(lstOffreId.Items[lstOffre.SelectedIndex].ToString())).DateLimite;
        }

        private void lstCandid_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewCritNote.Enabled = true;
            gpBoxEval.Enabled = true;

            dataGridViewCritNote.Rows.Clear();

            //On recupere le nom et le prenom du candidat
            string nom_candidat = "";
            string prenom_candidat = "";
            Boolean verif = false;
            for (int i = 0; i < lstCandid.Text.Length; i++)
            {
                if (verif == false)
                {
                    if (lstCandid.Text.ElementAt(i) != ' ' && lstCandid.Text.ElementAt(i + 1) != '|')
                    {
                        nom_candidat = nom_candidat + lstCandid.Text.ElementAt(i);
                    }
                    else
                    {
                        i += 2;
                        verif = true;
                    }
                }
                else
                {
                    prenom_candidat = prenom_candidat + lstCandid.Text.ElementAt(i);

                }
                lstCandid.Text.ElementAt(i);
            }

            //On créer une evaluation si elle existe pas dans la bdd
            DAOEvaluation.CreerEvaluation(conn, int.Parse(lstOffreNoterId.Items[lstOffreNoter.SelectedIndex].ToString()), nom_candidat, prenom_candidat, rhNom, rhPrenom);

            //On affiche dans le datagridview les criteres et les notes déjà noté par le RH
            Boolean first = true;            
            foreach(KeyValuePair<Critere,int> c in DAOCritere.GetCritereNoteByOffreNomPrenomRHNomPrenomCandid(conn, int.Parse(lstOffreNoterId.Items[lstOffreNoter.SelectedIndex].ToString()), rhNom, rhPrenom, prenom_candidat, nom_candidat))
            {
                if (first == true)
                {
                    first = false;
                    dataGridViewCritNote.Rows[0].Cells[0].Value = c.Key.Libelle;
                    dataGridViewCritNote.Rows[0].Cells[1].Value = c.Value;
                }
                else
                {
                    dataGridViewCritNote.Rows.Add(c.Key.Libelle, c.Value);
                }
            }

            //On affiche dans le datagridview les criteres qui ne sont pas noté par le RH
            foreach(Critere c in DAOCritere.GetCritereByOffreNomPrenomRH(conn, int.Parse(lstOffreNoterId.Items[lstOffreNoter.SelectedIndex].ToString())))
            {
                verif = false;
                if(first == false)
                {
                    for (int i = 0; i < dataGridViewCritNote.Rows.Count; i++)
                    {
                        if (dataGridViewCritNote.Rows[i].Cells[0].Value.ToString() == c.Libelle)
                        {
                            verif = true;
                        }
                    }
                }
                if(verif==false)
                {
                    if(first == true)
                    {
                        first = false;
                        dataGridViewCritNote.Rows[0].Cells[0].Value = c.Libelle;
                        dataGridViewCritNote.Rows[0].Cells[1].Value = "";
                    }
                    else
                    {
                        dataGridViewCritNote.Rows.Add(c.Libelle,"");
                    }
                }
            }

            //On affiche le commentaire et le bonus malus donnée par le RH sur cette candidature
            Evaluation evalu = DAOEvaluation.GetEvalByOffreNomPrenomCandidNomPrenomRH(conn, int.Parse(lstOffreNoterId.Items[lstOffreNoter.SelectedIndex].ToString()), nom_candidat, prenom_candidat, rhNom, rhPrenom);
            numUpDownBonusMalus.Value = evalu.Bonus_malus;
            richTextBoxCom.Text = evalu.Commentaire;
        }       

        private void btnEval_Click(object sender, EventArgs e)
        {
            string nom_candidat = "";
            string prenom_candidat = "";
            Boolean verif = false;
            for (int i = 0; i < lstCandid.Text.Length; i++)
            {
                if (verif == false)
                {
                    if (lstCandid.Text.ElementAt(i) != ' ' && lstCandid.Text.ElementAt(i + 1) != '|')
                    {
                        nom_candidat = nom_candidat + lstCandid.Text.ElementAt(i);
                    }
                    else
                    {
                        i += 2;
                        verif = true;
                    }
                }
                else
                {
                    prenom_candidat = prenom_candidat + lstCandid.Text.ElementAt(i);

                }
                lstCandid.Text.ElementAt(i);
            }
            DAOEvaluation.SetBonusMalusComs(conn, int.Parse(lstOffreNoterId.Items[lstOffreNoter.SelectedIndex].ToString()), nom_candidat, prenom_candidat, rhNom, rhPrenom,int.Parse(numUpDownBonusMalus.Value.ToString()),richTextBoxCom.Text);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            FichePDF.fiche();
        }

        private void dataGridViewCrit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string nom_candidat = "";
            string prenom_candidat = "";
            Boolean verif = false;
            for (int i = 0; i < lstCandid.Text.Length; i++)
            {
                if (verif == false)
                {
                    if (lstCandid.Text.ElementAt(i) != ' ' && lstCandid.Text.ElementAt(i + 1) != '|')
                    {
                        nom_candidat = nom_candidat + lstCandid.Text.ElementAt(i);
                    }
                    else
                    {
                        i += 2;
                        verif = true;
                    }
                }
                else
                {
                    prenom_candidat = prenom_candidat + lstCandid.Text.ElementAt(i);

                }
                lstCandid.Text.ElementAt(i);
            }
            DAOCritEval.SetNote(conn, int.Parse(lstOffreNoterId.Items[lstOffreNoter.SelectedIndex].ToString()), nom_candidat, prenom_candidat, int.Parse(dataGridViewCritNote.Rows[dataGridViewCritNote.CurrentRow.Index].Cells[1].Value.ToString()), rhNom, rhPrenom, dataGridViewCritNote.Rows[dataGridViewCritNote.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void dataGridViewCrit_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("fdhi");
        }

        private void dataGridViewCrit_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DAOCritere.DelCrit(conn, dataGridViewCrit.Rows[e.Row.Index].Cells[0].Value.ToString(), int.Parse(lstOffreId.Items[lstOffre.SelectedIndex].ToString()));
        }

        private void btnReu_Click(object sender, EventArgs e)
        {
            tabCtrl.SelectTab(1);
            dataGridViewReu.Rows.Clear();

            dataGridViewReu.Visible = true;
            int uneOffre = int.Parse(lstOffreId.Items[lstOffre.SelectedIndex].ToString());
            using (NpgsqlCommand cmd = new NpgsqlCommand("CREATE OR REPLACE VIEW v1 AS SELECT CANDIDATURE.nom_candidature AS candid_nom, CANDIDATURE.prenom_candidature AS candid_prenom, EVALUATION.nom_rh_evaluation AS rh_nom, EVALUATION.prenom_rh_evaluation AS rh_prenom, SUM(NOTER.note * ASSOCIER.coef) + EVALUATION.bonus_malus_evaluation AS note_total FROM CANDIDATURE INNER JOIN EVALUATION ON EVALUATION.id_candidature = CANDIDATURE.id_candidature INNER JOIN NOTER ON NOTER.id_evaluation = EVALUATION.id_evaluation INNER JOIN CRITERE ON CRITERE.id_critere = NOTER.id_critere INNER JOIN ASSOCIER ON ASSOCIER.id_critere = NOTER.id_critere WHERE CANDIDATURE.id_offre_emplois = " + uneOffre + " GROUP BY CANDIDATURE.nom_candidature, CANDIDATURE.prenom_candidature, EVALUATION.nom_rh_evaluation, EVALUATION.prenom_rh_evaluation,EVALUATION.bonus_malus_evaluation;", conn))
            {
                cmd.ExecuteNonQuery();
            }
            using (NpgsqlCommand cmd2 = new NpgsqlCommand("CREATE OR REPLACE VIEW v2 AS SELECT v1.candid_nom AS nom,v1.candid_prenom AS prenom, ROUND(AVG(v1.note_total),2) AS moyenne FROM v1 GROUP BY v1.candid_nom,v1.candid_prenom;", conn))
            {
                cmd2.ExecuteNonQuery();
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT v1.candid_nom, v1.candid_prenom, v2.moyenne, v1.RH_nom,v1.RH_prenom,v1.note_total FROM v1 INNER JOIN v2 ON v1.candid_nom = v2.nom AND v1.candid_prenom = v2.prenom ORDER BY Moyenne, v1.candid_nom, v1.candid_prenom;", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {

                int first = 1;
                while (reader.Read())
                {
                    bool verif = false;
                    int comp = 0;

                    //Colonne
                    for (int i = 0; i < dataGridViewReu.Columns.Count; i++)
                    {
                        if (dataGridViewReu.Columns[i].HeaderText == reader.GetString(3) + " " + reader.GetString(4))
                        {
                            verif = true;
                            comp = i;
                        }
                    }
                    if (verif == false)
                    {
                        dataGridViewReu.Columns.Add(reader.GetString(3) + "_" + reader.GetString(4), reader.GetString(3) + " " + reader.GetString(4));
                        comp = dataGridViewReu.ColumnCount - 1;
                    }

                    //Row
                    if (first != 1)
                    {
                        if (dataGridViewReu.Rows[0].Cells[0].Value.ToString() != reader.GetString(0) + " " + reader.GetString(1))
                        {
                            dataGridViewReu.Rows.Add();
                            dataGridViewReu.Rows[0].Cells[0].Value = reader.GetString(0) + " " + reader.GetString(1);
                            dataGridViewReu.Rows[0].Cells[1].Value = reader.GetInt32(2);
                        }
                        dataGridViewReu.Rows[0].Cells[comp].Value = reader.GetInt32(5);
                    }
                    else
                    {
                        dataGridViewReu.Rows[0].Cells[0].Value = reader.GetString(0) + " " + reader.GetString(1);
                        dataGridViewReu.Rows[0].Cells[1].Value = reader.GetInt32(2);
                        dataGridViewReu.Rows[0].Cells[comp].Value = reader.GetInt32(5);
                        first = -1;
                    }
                }
            }
        }

        private void lstOffreNoter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCandid.Enabled = true;
            dataGridViewCritNote.Enabled = false;
            gpBoxEval.Enabled = false;

            //Efface le bonus malus
            numUpDownBonusMalus.Value = 0;

            //Efface le commentaire
            richTextBoxCom.Clear();

            //Vide les notes et les critères
            dataGridViewCritNote.Rows.Clear();

            //Vide la liste des candidats
            lstCandid.Items.Clear();

            //Remplit les candidats de l'offre selectionné
            foreach (Candidature c in DAOCandidature.GetCandidatureByOffre(conn, int.Parse(lstOffreNoterId.Items[lstOffreNoter.SelectedIndex].ToString())))
            {
                lstCandid.Items.Add(c.Nom + " | " + c.Prenom);
            }
        }

        private void btnVerr_Click(object sender, EventArgs e)
        {
            //Verrouille l'offre selectionné
            DAOOffre.VerrouillerOffre(conn, int.Parse(lstOffreId.Items[lstOffre.SelectedIndex].ToString()));
        }
    }
}
