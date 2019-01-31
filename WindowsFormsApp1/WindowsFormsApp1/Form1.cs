using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn;
        Boolean drh = false;
        string rhNom = "Mabilon";
        string rhPrenom = "Loic";

        public Form1()
        {
            InitializeComponent();

            //Connexion bdd
            conn = Connexion.Connect();

            //Generation de la liste des offres
            foreach (Offre o in DAOOffre.GetOffre(conn))
            {
                lstOffre.Items.Add(o.Intitule);
            }

            if (this.drh == true)
            {
                label2.Visible = true;
                lstCrit.Visible = true;
                AddCrit.Visible = false;
                AddDate.Visible = false;
                gpBoxMod.Visible = false;
                gpBoxDateLimite.Visible = false;
                gpBoxAdd.Visible = false;
                lstCandid.Visible = false;
                gpNote.Visible = false;

                //Met la postition des groupBox
                gpBoxAdd.Location = new Point(299, 281);
                gpBoxMod.Location = new Point(299, 281);
                gpBoxDateLimite.Location = new Point(299, 281);
                lstCrit.Location = new Point(299, 72);
            }
            else
            {
                label2.Visible = false;
                lstCrit.Visible = false;
                AddCrit.Visible = false;
                AddDate.Visible = false;
                gpBoxMod.Visible = false;
                gpBoxDateLimite.Visible = false;
                gpBoxAdd.Visible = false;
                lstCandid.Visible = false;
                gpNote.Visible = false;

                //Se position
                lstCrit.Location = new Point(299, 281);
                lstCandid.Location = new Point(299, 72);
                gpNote.Location = new Point(535, 68);
                gpBoxEval.Location = new Point(535, 242);

            }
        }


        //Event sur la liste d'offre lors d'un changement de selection d'index
        private void lstOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.drh == true)
            {
                lstCrit.Enabled = true;
                AddDate.Visible = true;
                AddCrit.Visible = true;
                gpBoxMod.Visible = false;
                gpBoxAdd.Visible = false;
                gpBoxDateLimite.Visible = false;
                btnPDF.Visible = true;
                //Reinitialise la liste des criteres
                lstCrit.Items.Clear();
                //Ajout des criteres de l'offre dans la liste de critère
                foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(conn, lstOffre.SelectedIndex + 1))
                {
                    lstCrit.Items.Add(o.Key.Libelle);

                }
                dateTimePicker.Value = DAOOffre.GetOffreById(conn, lstOffre.SelectedIndex + 1).DateLimite;

            }
            else
            {
                lstCandid.Visible = true;
                gpNote.Visible = false;
                lstCrit.Visible = false;
                gpBoxEval.Visible = false;
                lstCandid.Items.Clear();
                foreach (Candidature c in DAOCandidature.GetCandidatureByOffre(conn, lstOffre.SelectedIndex + 1))
                {
                    lstCandid.Items.Add(c.Nom + " | " + c.Prenom);
                }
            }
        }


        private void btnAddCrit_Click(object sender, EventArgs e)
        {
            DAOCritere.AddCrit(conn, comboBoxCritAdd.Text, double.Parse(txtBoxCritCoefAdd.Text), lstOffre.SelectedIndex+1);

            //Reinitialise la liste des criteres
            lstCrit.Items.Clear();
            //Ajout des criteres de l'offre dans la liste de critère
            foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(conn, lstOffre.SelectedIndex + 1))
            {
                lstCrit.Items.Add(o.Key.Libelle);
            }
            dateTimePicker.Value = DAOOffre.GetOffreById(conn, lstOffre.SelectedIndex + 1).DateLimite;

            AddDate.Visible = true;
            AddCrit.Visible = true;
            gpBoxMod.Visible = false;
            gpBoxAdd.Visible = false;
            gpBoxDateLimite.Visible = false;
            AddDate.Enabled = true;
            AddCrit.Enabled = true;
        }

        private void btnModCrit_Click(object sender, EventArgs e)
        {
            DAOCritere.ModifCrit(conn, txtBoxCritMod.Text, double.Parse(txtBoxCritCoefMod.Text), lstOffre.SelectedIndex+1);

            //Reinitialise la liste des criteres
            lstCrit.Items.Clear();
            //Ajout des criteres de l'offre dans la liste de critère
            foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(conn, lstOffre.SelectedIndex + 1))
            {
                lstCrit.Items.Add(o.Key.Libelle);
            }
            dateTimePicker.Value = DAOOffre.GetOffreById(conn, lstOffre.SelectedIndex + 1).DateLimite;

            AddDate.Visible = true;
            AddCrit.Visible = true;
            gpBoxMod.Visible = false;
            gpBoxAdd.Visible = false;
            gpBoxDateLimite.Visible = false;
            AddDate.Enabled = true;
            AddCrit.Enabled = true;
        }

        private void lstCrit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.drh == true)
            {
                AddDate.Enabled = true;
                AddCrit.Enabled = true;
                gpBoxMod.Visible = true;
                gpBoxAdd.Visible = false;
                gpBoxDateLimite.Visible = false;

                foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(conn, lstOffre.SelectedIndex + 1))
                {
                    if (o.Key.Libelle == lstCrit.Text)
                    {
                        txtBoxCritMod.Text = o.Key.Libelle;
                        txtBoxCritCoefMod.Text = o.Value.ToString();
                    }
                }
            }
            else
            {
                lstCandid.Visible = true;
                gpNote.Visible = true;
                lstCrit.Visible = true;

                //Recuperation du nom et du prenom
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
                int laNote = -1;
                foreach (KeyValuePair<Critere, int> c in DAOCritere.GetCritereNoteByOffreNomPrenomRHNomPrenomCandid(conn,lstOffre.SelectedIndex+1,rhNom,rhPrenom, prenom_candidat, nom_candidat, lstCrit.Text))
                {
                    laNote = c.Value;                    
                }
                txtBoxCrit.Text = lstCrit.Text;
                if (laNote == 0)
                {
                    radBtnNote0.Checked = true;
                    radBtnNote1.Checked = false;
                    radBtnNote2.Checked = false;
                    radBtnNote3.Checked = false;
                    radBtnNote4.Checked = false;
                    radBtnNote5.Checked = false;
                }
                else
                {
                    if (laNote == 1)
                    {
                        radBtnNote0.Checked = false;
                        radBtnNote1.Checked = true;
                        radBtnNote2.Checked = false;
                        radBtnNote3.Checked = false;
                        radBtnNote4.Checked = false;
                        radBtnNote5.Checked = false;
                    }
                    else
                    {
                        if (laNote == 2)
                        {
                            radBtnNote0.Checked = false;
                            radBtnNote1.Checked = true;
                            radBtnNote2.Checked = false;
                            radBtnNote3.Checked = false;
                            radBtnNote4.Checked = false;
                            radBtnNote5.Checked = false;

                        }
                        else
                        {
                            if (laNote == 3)
                            {
                                radBtnNote0.Checked = false;
                                radBtnNote1.Checked = false;
                                radBtnNote2.Checked = false;
                                radBtnNote3.Checked = true;
                                radBtnNote4.Checked = false;
                                radBtnNote5.Checked = false;
                            }
                            else
                            {
                                if (laNote == 4)
                                {
                                    radBtnNote0.Checked = false;
                                    radBtnNote1.Checked = false;
                                    radBtnNote2.Checked = false;
                                    radBtnNote3.Checked = false;
                                    radBtnNote4.Checked = true;
                                    radBtnNote5.Checked = false;
                                }
                                else
                                {
                                    if (laNote == 5)
                                    {
                                        radBtnNote0.Checked = false;
                                        radBtnNote1.Checked = false;
                                        radBtnNote2.Checked = false;
                                        radBtnNote3.Checked = false;
                                        radBtnNote4.Checked = false;
                                        radBtnNote5.Checked = true;
                                    }
                                    else
                                    {
                                        radBtnNote0.Checked = false;
                                        radBtnNote1.Checked = false;
                                        radBtnNote2.Checked = false;
                                        radBtnNote3.Checked = false;
                                        radBtnNote4.Checked = false;
                                        radBtnNote5.Checked = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
            


        private void AddCrit_Click(object sender, EventArgs e)
        {
            //Mode ajouter critère
            AddDate.Enabled = true;
            AddCrit.Enabled = false;
            gpBoxMod.Visible = false;
            gpBoxAdd.Visible = true;
            gpBoxDateLimite.Visible = false;

            comboBoxCritAdd.Items.Clear();
            foreach (Critere c in DAOCritere.GetCritere(this.conn))
            {
                comboBoxCritAdd.Items.Add(c.Libelle);
            }
        }

        //Deconnexion de la bdd lors de la fermeture du form
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Connexion.Deconnect(conn);
        }


        //Permet à cette textBox d'accepter que des int,double, numeric...
        private void txtBoxCritCoefAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtBoxCritCoefMod.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        //Permet à cette textBox d'accepter que des int,double, numeric...
        private void txtBoxCritCoefMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtBoxCritCoefMod.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnSuppCrit_Click(object sender, EventArgs e)
        {
            DAOCritere.DelCrit(conn, txtBoxCritMod.Text, lstOffre.SelectedIndex + 1);

            //Reinitialise la liste des criteres
            lstCrit.Items.Clear();
            //Ajout des criteres de l'offre dans la liste de critère
            foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(conn, lstOffre.SelectedIndex + 1))
            {
                lstCrit.Items.Add(o.Key.Libelle);
            }
            dateTimePicker.Value = DAOOffre.GetOffreById(conn, lstOffre.SelectedIndex + 1).DateLimite;

            AddDate.Visible = true;
            AddCrit.Visible = true;
            gpBoxMod.Visible = false;
            gpBoxAdd.Visible = false;
            gpBoxDateLimite.Visible = false;
            AddDate.Enabled = true;
            AddCrit.Enabled = true;
        }

        private void btnDateLimite_Click(object sender, EventArgs e)
        {
            DAOOffre.SetDateLimite(conn, lstOffre.SelectedIndex+1, dateTimePicker.Value);

            //Reinitialise la liste des criteres
            lstCrit.Items.Clear();
            //Ajout des criteres de l'offre dans la liste de critère
            foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(conn, lstOffre.SelectedIndex + 1))
            {
                lstCrit.Items.Add(o.Key.Libelle);
            }
            dateTimePicker.Value = DAOOffre.GetOffreById(conn, lstOffre.SelectedIndex + 1).DateLimite;

            AddDate.Visible = true;
            AddCrit.Visible = true;
            gpBoxMod.Visible = false;
            gpBoxAdd.Visible = false;
            gpBoxDateLimite.Visible = false;
            AddDate.Enabled = true;
            AddCrit.Enabled = true;
        }

        private void AddDate_Click(object sender, EventArgs e)
        {
            AddDate.Enabled = false;
            AddCrit.Enabled = true;
            gpBoxMod.Visible = false;
            gpBoxAdd.Visible = false;
            gpBoxDateLimite.Visible = true;
        }

        private void lstCandid_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpBoxEval.Visible = false;
            txtBoxCrit.Clear();
            radBtnNote0.Checked = false;
            radBtnNote1.Checked = false;
            radBtnNote2.Checked = false;
            radBtnNote3.Checked = false;
            radBtnNote4.Checked = false;
            radBtnNote5.Checked = false;
            lstCandid.Visible = true;
            gpNote.Visible = false;
            lstCrit.Visible = true;
            lstCrit.Items.Clear();
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
            foreach (Critere c in DAOCritere.GetCritereByOffreNomPrenomRH(conn, lstOffre.SelectedIndex + 1))
            {
                lstCrit.Items.Add(c.Libelle);
            }

            if (DAOCritEval.GetNombreNoteByOffreNomPrenomRHNomPrenomCandid(conn, lstOffre.SelectedIndex + 1, nom_candidat, prenom_candidat, rhNom, rhPrenom) == DAOCritere.GetCritereByOffreNomPrenomRH(conn, lstOffre.SelectedIndex + 1).Count)
            {
                gpBoxEval.Visible = true;
                Evaluation evalu = DAOEvaluation.GetEvalByOffreNomPrenomCandidNomPrenomRH(conn, lstOffre.SelectedIndex + 1, nom_candidat, prenom_candidat, rhNom, rhPrenom);
                numUpDownBonusMalus.Value = evalu.Bonus_malus;
                richTextBoxCom.Text = evalu.Commentaire;

            }
        }

        private void btnNoter_Click(object sender, EventArgs e)
        {
            int note = -1;
            if (radBtnNote0.Checked == true)
            {
                note = 0;
            }
            else
            {
                if (radBtnNote1.Checked == true)
                {
                    note = 1;
                }
                else
                {
                    if (radBtnNote2.Checked == true)
                    {
                        note = 2;
                    }
                    else
                    {
                        if (radBtnNote3.Checked == true)
                        {
                            note = 3;
                        }
                        else
                        {
                            if (radBtnNote4.Checked == true)
                            {
                                note = 4;
                            }
                            else
                            {
                                if (radBtnNote5.Checked == true)
                                {
                                    note = 5;
                                }
                            }
                        }
                    }
                }
            }
            string nom_candidat = "";
            string prenom_candidat = "";
            Boolean verif = false;
            for (int i=0; i<lstCandid.Text.Length;i++)
            {
                if(verif == false)
                {
                    if(lstCandid.Text.ElementAt(i) != ' ' && lstCandid.Text.ElementAt(i + 1) != '|')
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
            DAOCritEval.SetNote(conn, lstOffre.SelectedIndex + 1, nom_candidat, prenom_candidat, note, rhNom, rhPrenom,txtBoxCrit.Text);
            lstCandid_SelectedIndexChanged(sender, e);
            lstCrit_SelectedIndexChanged(sender, e);

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
            DAOEvaluation.SetBonusMalusComs(conn, lstOffre.SelectedIndex + 1, nom_candidat, prenom_candidat,rhNom, rhPrenom,int.Parse(numUpDownBonusMalus.Value.ToString()),richTextBoxCom.Text);
            lstCandid_SelectedIndexChanged(sender,e);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            FichePDF.fiche();
        }

        private void btnReunion_Click(object sender, EventArgs e)
        {
            dataGridViewReu.Visible = true;
            int uneOffre = lstOffre.SelectedIndex+1;
            using (NpgsqlCommand cmd = new NpgsqlCommand("CREATE OR REPLACE VIEW v1 AS SELECT CANDIDATURE.nom_candidature AS candid_nom, CANDIDATURE.prenom_candidature AS candid_prenom, EVALUATION.nom_rh_evaluation AS rh_nom, EVALUATION.prenom_rh_evaluation AS rh_prenom, SUM(NOTER.note * ASSOCIER.coef) + EVALUATION.bonus_malus_evaluation AS note_total FROM CANDIDATURE INNER JOIN EVALUATION ON EVALUATION.id_candidature = CANDIDATURE.id_candidature INNER JOIN NOTER ON NOTER.id_evaluation = EVALUATION.id_evaluation INNER JOIN CRITERE ON CRITERE.id_critere = NOTER.id_critere INNER JOIN ASSOCIER ON ASSOCIER.id_critere = NOTER.id_critere WHERE CANDIDATURE.id_offre_emplois = " + uneOffre + " GROUP BY CANDIDATURE.nom_candidature, CANDIDATURE.prenom_candidature, EVALUATION.nom_rh_evaluation, EVALUATION.prenom_rh_evaluation,EVALUATION.bonus_malus_evaluation;", conn))
            {
                cmd.ExecuteNonQuery();
            }
            using (NpgsqlCommand cmd2 = new NpgsqlCommand("CREATE OR REPLACE VIEW v2 AS SELECT v1.candid_nom AS nom,v1.candid_prenom AS prenom, ROUND(AVG(v1.note_total),2) AS moyenne FROM v1 GROUP BY v1.candid_nom,v1.candid_prenom;", conn))
            {
                cmd2.ExecuteNonQuery();
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT v1.candid_nom, v1.candid_prenom, v2.moyenne, v1.RH_nom,v1.RH_prenom,v1.note_total FROM v1 INNER JOIN v2 ON v1.candid_nom = v2.nom AND v1.candid_prenom = v2.prenom ORDER BY Moyenne;", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                int first = 1;
                string[] row = new string[] { };
                while (reader.Read())
                {
                    bool verif = false;
                    int comp = 0;
                    //Colonne
                    for(int i=0;i<dataGridViewReu.Columns.Count;i++)
                    {
                        if(dataGridViewReu.Columns[i].HeaderText == reader.GetString(3)+" "+reader.GetString(4))
                        {
                            verif = true;
                            comp = i;
                        }
                    }
                    if (verif==false)
                    {
                        dataGridViewReu.Columns.Add(reader.GetString(3) + "_" + reader.GetString(4), reader.GetString(3) + " " + reader.GetString(4));
                        comp = dataGridViewReu.ColumnCount - 1;
                    }

                    //Row
                    if(first !=1)
                    {
                        if (dataGridViewReu.Rows[0].Cells[0].Value.ToString() == reader.GetString(0) + " " + reader.GetString(1))
                        {
                            dataGridViewReu.Rows[0].Cells[comp].Value = reader.GetInt32(5);
                        }
                        else
                        {
                            dataGridViewReu.Rows.Add();
                            dataGridViewReu.Rows[0].Cells[0].Value = reader.GetString(0) + " " + reader.GetString(1);
                            dataGridViewReu.Rows[0].Cells[1].Value = reader.GetInt32(2);
                            dataGridViewReu.Rows[0].Cells[comp].Value = reader.GetInt32(5);
                        }
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
    }
}
