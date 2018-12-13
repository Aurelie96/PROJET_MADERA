using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Model
{
    public class Module
    {
        public int idModule { get; set; }
        public string nomModule { get; set; }
        public float prixHTModule { get; set; }
        public int nbSectionModule { get; set; }
        public int coordonneeDebutXModule { get; set; }
        public int coordonneeDebutYModule { get; set; }
        public int coordonneeFinXModule { get; set; }
        public int coordonneeFinYModule { get; set; }
        public int idSectionModule { get; set; }

        public Module(int id, string nom, float prix, int nbSection,
            int coordonneeDebutX, int coordonneeDebutY, int coordonneeFinX,
            int coordonneeFinY, int idSection)
        {
            this.idModule = id;
            this.nomModule = nom;
            this.prixHTModule = prix;
            this.nbSectionModule = nbSection;
            this.coordonneeDebutXModule = coordonneeDebutX;
            this.coordonneeDebutYModule = coordonneeDebutY;
            this.coordonneeFinXModule = coordonneeFinX;
            this.coordonneeFinYModule = coordonneeFinY;
            this.idSectionModule = idSection;
        }
    }
}
