using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Model
{
    public class ObjectifModule
    {
        public int idObjectifModule { get; set; }
        public string labelObjectifModule { get; set; }
        public float prixObjectifModule { get; set; }
        public int idForme { get; set; }
        public int idComposant { get; set; }
        public int idModule { get; set; }

        public ObjectifModule(int id, string label, float prix, int idforme,
            int idcomposant, int idmodule)
        {
            this.idObjectifModule = id;
            this.labelObjectifModule = label;
            this.prixObjectifModule = prix;
            this.idForme = idforme;
            this.idComposant = idcomposant;
            this.idModule = idmodule;
        }
    }
}
