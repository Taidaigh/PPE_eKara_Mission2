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
            //Bouton pour ajouter un critere
            //Mettre dans la bdd le critere (bdd critere et associer)
            //Afficher les criteres d'une offre selectionné
        }

        private void lstOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCrit.Items.Clear();
            foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(conn,lstOffre.SelectedIndex+1))
            {
                lstCrit.Items.Add(o.Key.Libelle);
            }
            btnAddCrit.Enabled = true;
            txtBoxCritCoef.Enabled = true;
            txtBoxCrit.Enabled = true;
            AddCrit.Enabled = true;
            groupBoxCrit.Text = "Ajouter un critère";
            btnAddCrit.Text = "Ajouter";
        }

        private void btnAddCrit_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(conn, lstOffre.SelectedIndex+1);
            f2.Show();
            if (txtBoxCrit.Enabled == true)
            {
                //Add
            }
            else
            {
                //Modif
            }
        }

        private void listCrit_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddCrit.Enabled = false;
            txtBoxCritCoef.Enabled = true;
            txtBoxCrit.Enabled = false;
            groupBoxCrit.Text = "Modifier un critère";
            btnAddCrit.Text = "Modifier";

            foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(conn, lstOffre.SelectedIndex + 1))
            {
                if (o.Key.Libelle == lstCrit.Text)
                {
                    txtBoxCrit.Text = o.Key.Libelle;
                    txtBoxCritCoef.Text = o.Value.ToString();
                }                
            }
        }

        private void txtBoxCritCoef_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtBoxCritCoef.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void AddCrit_Click(object sender, EventArgs e)
        {
            btnAddCrit.Enabled = true;
            txtBoxCritCoef.Enabled = true;
            txtBoxCrit.Enabled = true;

            groupBoxCrit.Text = "Ajouter un critère";
            btnAddCrit.Text = "Ajouter";
            lstCrit.SelectedIndex = -1;
            txtBoxCrit.Clear();
            txtBoxCritCoef.Clear();
            btnAddCrit.Enabled = true;
            txtBoxCritCoef.Enabled = true;
            txtBoxCrit.Enabled = true;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Connexion.Deconnect(conn);
        }
    }
}
