using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Candidature
    {
        int id;
        string nom;
        string prenom;
        DateTime date;
        string statut;

        public Candidature(int unId, string unNom, String unPrenom, DateTime uneDate,string unStatut)
        {
            this.id = unId;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.date = uneDate;
            this.statut = unStatut;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Statut { get => statut; set => statut = value; }
    }
}
