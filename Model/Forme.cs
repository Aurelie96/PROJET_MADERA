using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Model
{
    public class Forme
    {
        public int idForme { get; set; }
        public string labelForme { get; set; }
        public float longueurForme { get; set; }
        public float largeurForme { get; set; }
        public float prixHTForme { get; set; }

        public Forme(int id, string label, float longeur, float largeur, float prixHT)
        {
            this.idForme = id;
            this.labelForme = label;
            this.longueurForme = longeur;
            this.largeurForme = largeur;
            this.prixHTForme = prixHT;
        }
    }
}
