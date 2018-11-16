using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Modele
{
    public class Section
    {
        public int idSection { get; set; }
        public string labelSection { get; set; }

        public Section(int id, string label)
        {
            this.idSection = id;
            this.labelSection = label;
        }
    }
}
