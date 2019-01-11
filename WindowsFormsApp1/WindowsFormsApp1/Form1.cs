using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            foreach(string o in DAOOffre.GetOffre())
            {
                lstOffre.Items.Add(o);
            }
            //Connexion bdd
            //Affichage des Offres

            //Bouton pour ajouter un critere
            //Mettre dans la bdd le critere (bdd critere et associer)
            //Afficher les criteres d'une offre selectionné
        }

        private void lstOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstViewCrit.Refresh();
            lstViewCrit.View = View.Details; // pour avoir l'affichage en mode détail (une ligne à la fois)
            lstViewCrit.Columns.Add("Critère", lstViewCrit.Width / 2); // on ajoute une première colonne
            foreach (int o in DAOCritere.GetCritereOffre(1).Keys)
            {
                ListViewItem lvi = new ListViewItem(o.ToString());
                lstViewCrit.Items.Add(lvi); // tu ajoute ton item à la liste des items de la listView 
            }

            lstViewCrit.Columns.Add("Coef", lstViewCrit.Width / 2); // on ajoute une deuxième colonne

            foreach (string o in DAOCritere.GetCritereOffre(1).Values)
            {
                ListViewItem lvi = new ListViewItem(o);
                lstViewCrit.Items.Add(lvi); // tu ajoute ton item a la liste des items de la listView 
            }
            btnAddCrit.Enabled = true;
        }

        private void btnAddCrit_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }
    }
}
