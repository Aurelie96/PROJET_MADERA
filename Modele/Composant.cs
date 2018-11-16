using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Modele
{
    public class Composant
    {
        public int idComposant { get; set; }
        public string nomComposant { get; set; }
        public int idFamille { get; set; }

        public Composant(int id, string nom, int idfamille)
        {
            this.idComposant = id;
            this.nomComposant = nom;
            this.idFamille = idfamille;
        }
    }
}
