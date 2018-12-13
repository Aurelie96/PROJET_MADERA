using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Model
{
    public class Sol
    {
        public int idSol { get; set; }
        public string typeSol { get; set; }
        public float prixHTSol { get; set; }

        public Sol(int id, string type, float prix)
        {
            this.idSol = id;
            this.typeSol = type;
            this.prixHTSol = prix;
        }
    }
}
