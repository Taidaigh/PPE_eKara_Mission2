using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CritOffre
    {
        int id_crit;
        int id_offre;
        string coef;

        public CritOffre(int unIdCrit, int unIdOffre, string unCoef)
        {
            this.id_crit = unIdCrit;
            this.id_offre = unIdOffre;
            this.coef = unCoef;
        }
    }
}
