using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Model
{
    public class Gamme
    {
        public int idGamme { get; set; }
        public string offrePromoGamme { get; set; }
        public string qualiteHuisserieGamme { get; set; }
        public string typeIsolantGamme { get; set; }
        public string typeFinitionGamme { get; set; }
        public Gamme(int id, string offrePromo, string qualiteHuisserie, string typeIsolant, string typeFinition)
        {
            this.idGamme = id;
            this.offrePromoGamme = offrePromo;
            this.qualiteHuisserieGamme = qualiteHuisserie;
            this.typeIsolantGamme = typeIsolant;
            this.typeFinitionGamme = typeFinition;
        }
    }
}
