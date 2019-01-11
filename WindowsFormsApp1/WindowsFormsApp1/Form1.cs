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
            
            foreach(Offre o in DAOOffre.GetOffre())
            {
                lstOffre.Items.Add(o.Intitule);
            }
            //Connexion bdd
            //Affichage des Offres

            //Bouton pour ajouter un critere
            //Mettre dans la bdd le critere (bdd critere et associer)
            //Afficher les criteres d'une offre selectionné
        }

        private void lstOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewCrit.Refresh();
            foreach (KeyValuePair<int, Critere> o in DAOCritere.GetCritereCoefByOffre(1))
            {
                string[] row = new string[] { o.Key.ToString(), o.Value.Libelle};
                GridViewCrit.Rows.Add(row);
            }
            btnAddCrit.Enabled = true;
        }

        private void btnAddCrit_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

    }
}
