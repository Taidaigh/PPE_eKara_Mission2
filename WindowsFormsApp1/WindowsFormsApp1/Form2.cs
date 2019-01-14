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
    public partial class Form2 : Form
    {
        //Connection bdd
        NpgsqlConnection conn;
        //Index de l'offre
        int offre;
        public Form2(NpgsqlConnection uneConn,int loffre)
        {
            InitializeComponent();
            this.conn = uneConn;
            this.offre = loffre;
            GridViewCrit.Rows.Clear();
            foreach (KeyValuePair<Critere,double> o in DAOCritere.GetCritereCoefByOffre(this.conn, this.offre))
            {
                string[] row = { o.Key.Libelle, o.Value.ToString() };
                GridViewCrit.Rows.Add(row);
            }
            foreach (Critere c in DAOCritere.GetCritere(this.conn))
            {
                ComboBoxCritAdd.Items.Add(c.Libelle);
            }
        }

        private void btnCritAdd_Click(object sender, EventArgs e)
        {
            //Ajoute un Critere
            DAOCritere.AddCrit(conn,ComboBoxCritAdd.Text, double.Parse(numUpCoefAdd.Value.ToString()), this.offre);

            //Actualise le DataGridView
            GridViewCrit.Rows.Clear();
            foreach (KeyValuePair<Critere, double> o in DAOCritere.GetCritereCoefByOffre(this.conn, this.offre))
            {
                string[] row = { o.Key.Libelle, o.Value.ToString() };
                GridViewCrit.Rows.Add(row);
            }
        }

        private void btnCritMod_Click(object sender, EventArgs e)
        {
            //GridViewCrit.CurrentCell.RowIndex;
            int crit = GridViewCrit.CurrentCell.RowIndex;
            int compt = 0;
            foreach(Critere c in DAOCritere.GetCritereCoefByOffre(this.conn,this.offre).Keys)
            {
                if(crit == compt)
                {
                    DAOCritere.ModifCrit(this.conn, double.Parse(numUpCoefMod.Value.ToString()), c.Id, this.offre);
                }
                compt++;
            }

            GridViewCrit.Rows.Clear();
            foreach (KeyValuePair<Critere,double> o in DAOCritere.GetCritereCoefByOffre(this.conn, this.offre))
            {
                string[] row = { o.Key.Libelle, o.Value.ToString() };
                GridViewCrit.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            numUpCoefMod.Enabled = true;
            btnCritMod.Enabled = true;
        }

        private void ComboBoxCritAdd_TextChanged(object sender, EventArgs e)
        {
            if(double.Parse(ComboBoxCritAdd.Text)>0)
            {
                btnCritAdd.Enabled = true;
            }
            else
            {
                btnCritAdd.Enabled = false;
            }
        }
    }
}
