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
    }
}
