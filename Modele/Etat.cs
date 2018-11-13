using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Modele
{
    public class Etat
    {
        public int idEtat { get; set; }
        public string libelleEtat { get; set; }

        public Etat(int id, string libelle)
        {
            this.idEtat = id;
            this.libelleEtat = libelle;
        }
    }
}
