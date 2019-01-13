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
            foreach (KeyValuePair<double, Critere> o in DAOCritere.GetCritereCoefByOffre(conn, offre))
            {
                string[] row = { o.Key.ToString(), o.Value.Libelle };
                GridViewCrit.Rows.Add(row);
            }
        }

        private void btnCritAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCritMod_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
