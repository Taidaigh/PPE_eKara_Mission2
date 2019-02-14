using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Npgsql;

namespace WindowsFormsApp1
{
    public class FichePDF
    {
        private static string nomFichierPDF = "Y:/fiche_individuelle.pdf";
        
        public static void fiche(int idCandidat)
        {
            idCandidat = 1;
            NpgsqlConnection conn;
            conn = Connexion.Connect();
            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(nomFichierPDF, FileMode.Create));

            doc.AddTitle("Fiche individuelle");

            doc.Open();

            PdfContentByte cb = writer.DirectContent;

            cb.BeginText();
            BaseFont bf = BaseFont.CreateFont("C:\\WINDOWS\\FONTS\\arial.TTF", BaseFont.CP1252, true);
            cb.SetRGBColorFill(66, 133, 244);
            cb.SetFontAndSize(bf, 15f);
            cb.SetTextMatrix(150, 700);
            cb.ShowText("FICHE INDIVIDUELLE DE CANDIDATURE");
            cb.SetTextMatrix(100, 630);
            cb.ShowText("Poste");
            string poste;
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT intitule_offre_emplois FROM offre_emplois o INNER JOIN candidature c ON o.id_offre_emplois = c.id_offre_emplois WHERE id_candidature = "+ idCandidat +";", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    poste = reader.GetString(0);
                    cb.SetTextMatrix(100, 610);
                    cb.ShowText(poste);
                }
            }
            cb.SetTextMatrix(100, 560);
            cb.ShowText("Candidat");
            cb.SetTextMatrix(100, 530);
            cb.ShowText("Nom :");
            string nom;
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT nom_candidature FROM candidature WHERE id_candidature = "+ idCandidat +";", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    nom = reader.GetString(0);
                    cb.SetTextMatrix(150, 530);
                    cb.ShowText(nom);
                }
            }
            cb.SetTextMatrix(300, 530);
            cb.ShowText("Prénom :");
            string prenom;
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT prenom_candidature FROM candidature WHERE id_candidature = "+ idCandidat +";", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    prenom = reader.GetString(0);
                    cb.SetTextMatrix(380, 530);
                    cb.ShowText(prenom);
                }
            }
            cb.SetTextMatrix(100, 430);
            cb.ShowText("Évaluations");
            PdfPTable table = new PdfPTable(3);
            PdfPCell cell = new PdfPCell();
            cell.Colspan = 3;
            table.AddCell(cell);
            table.AddCell("Évaluateur");
            table.AddCell("Note globale");
            table.AddCell("Commentaire");
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT prenom_rh_evaluation, note, commentaire_evaluation FROM evaluation e INNER JOIN noter n ON n.id_evaluation = e.id_evaluation;", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    table.AddCell(reader[0].ToString());
                    table.AddCell(reader[1].ToString());
                    table.AddCell(reader[2].ToString());
                }
            }
            doc.Add(table);
            cb.EndText();

            doc.Close();
        }
    }
}
