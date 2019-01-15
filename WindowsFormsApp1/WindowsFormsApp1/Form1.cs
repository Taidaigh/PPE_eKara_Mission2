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

            //Met la postition des groupBox
            gpBoxAdd.Location = new Point(299, 281);
            gpBoxMod.Location = new Point(299, 281);
            gpBoxDateLimite.Location = new Point(299, 281);
        }


        //Event sur la liste d'offre lors d'un changement de selection d'index
        private void lstOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCrit.Enabled = true;
            //Reinitialise la liste des criteres
            lstCrit.Items.Clear();
            //Ajout des criteres de l'offre dans la liste de critère
            foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(conn,lstOffre.SelectedIndex+1))
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


        private void btnAddCrit_Click(object sender, EventArgs e)
        {
            DAOCritere.AddCrit(conn, comboBoxCritAdd.Text, double.Parse(txtBoxCritCoefAdd.Text), lstOffre.SelectedIndex);
        }

        private void btnModCrit_Click(object sender, EventArgs e)
        {
            DAOCritere.ModifCrit(conn, txtBoxCritMod.Text, double.Parse(txtBoxCritCoefMod.Text), lstOffre.SelectedIndex);
        }

        private void listCrit_SelectedIndexChanged(object sender, EventArgs e)
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
            lstOffre.SelectedIndex = lstOffre.SelectedIndex;
        }

        private void btnDateLimite_Click(object sender, EventArgs e)
        {
            DAOOffre.SetDateLimite(conn, lstOffre.SelectedIndex+1, dateTimePicker.Value);
            lstOffre.SelectedIndex = lstOffre.SelectedIndex;
        }

        private void AddDate_Click(object sender, EventArgs e)
        {
            AddDate.Enabled = false;
            AddCrit.Enabled = true;
            gpBoxMod.Visible = false;
            gpBoxAdd.Visible = false;
            gpBoxDateLimite.Visible = true;
        }
    }
}
