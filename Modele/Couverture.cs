using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Modele
{
    public class Couverture
    {
        public int idCouverture { get; set; }
        public string typeCouverture { get; set; }
        public float prixHTCouverture { get; set; }

        public Couverture(int id, string type, float prix)
        {
            this.idCouverture = id;
            this.typeCouverture = type;
            this.prixHTCouverture = prix;
        }
    }
}
