using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApp1
{
    public class FichePDF
    {
        private static string nomFichierPDF = "Y:/fiche_individuelle.pdf";

        public static void fiche()
        {
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
            cb.EndText();

            doc.Close();
        }
    }
}
