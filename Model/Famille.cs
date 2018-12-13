using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Model
{
    public class Famille
    {
        public int idFamille { get; set; }
        public string nomFamille { get; set; }

        public Famille(int id, string nom)
        {
            this.idFamille = id;
            this.nomFamille = nom;
        }
    }
}
