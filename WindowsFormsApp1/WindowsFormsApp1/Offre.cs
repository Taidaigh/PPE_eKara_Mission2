using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Offre
    {
        int id;
        string intitule;
        string lieux;
        double salaire;
        DateTime dateLimite;

        public Offre(int unId, string unIntitule, string unLieux, double unSalaire, DateTime uneDateLimite)
        {
            this.id = unId;
            this.intitule = unIntitule;
            this.lieux = unLieux;
            this.salaire = unSalaire;
            this.dateLimite = uneDateLimite;
        }

        public int Id { get => id; set => id = value; }
        public string Intitule { get => intitule; set => intitule = value; }
        public string Lieux { get => lieux; set => lieux = value; }
        public double Salaire { get => salaire; set => salaire = value; }
        public DateTime DateLimite { get => dateLimite; set => dateLimite = value; }
    }
}
