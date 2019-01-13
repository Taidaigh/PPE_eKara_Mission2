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
            GridViewCrit.Rows.Clear();
            foreach (KeyValuePair<double, Critere> o in DAOCritere.GetCritereCoefByOffre(conn,lstOffre.SelectedIndex))
            {
                string[] row = { o.Key.ToString(), o.Value.Libelle };
                GridViewCrit.Rows.Add(row);
            }
            btnAddCrit.Enabled = true;
        }

        private void btnAddCrit_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(conn, lstOffre.SelectedIndex);
            f2.Show();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Connexion.Deconnect(conn);
        }
    }
}
