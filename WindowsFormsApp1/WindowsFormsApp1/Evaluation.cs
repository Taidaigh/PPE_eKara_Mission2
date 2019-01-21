using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Evaluation
    {
        int id;
        string nom_rh;
        string prenom_rh;
        int bonus_malus;
        string commentaire;

        public Evaluation(int unId, string unNomRh, string unPrenomRh, int unBonusMalus, string unCommentaire)
        {
            this.id = unId;
            this.nom_rh = unNomRh;
            this.prenom_rh = unPrenomRh;
            this.bonus_malus = unBonusMalus;
            this.commentaire = unCommentaire;
        }

        public int Id { get => id; set => id = value; }
        public string Nom_rh { get => nom_rh; set => nom_rh = value; }
        public string Prenom_rh { get => prenom_rh; set => prenom_rh = value; }
        public int Bonus_malus { get => bonus_malus; set => bonus_malus = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
    }
}
