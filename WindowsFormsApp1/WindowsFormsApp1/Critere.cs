﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Critere
    {
        int id;
        string libelle;

        public Critere(int unId, string unLibelle)
        {
            this.id = unId;
            this.libelle = unLibelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
