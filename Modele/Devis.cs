using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Modele
{
    public class Devis
    {
        public int idDevis { get; set; }
        public string nomDevis { get; set; }
        public DateTime dateDevis { get; set; }
        public int quantiteDevis { get; set; }
        public int uniteDevis { get; set; }
        public float prixHTDevis { get; set; }
        public float prixTTDevis { get; set; }
        public int margeCommercialDevis { get; set; }
        public int margeEntrepriseDevis { get; set; }
        public int idEtat { get; set; }

        public Devis(int id, string nom, DateTime date, int quantite, int unite, float prixHT, 
            float prixTT, int margeCommercial, int margeEntreprise, int id_Etat)
        {
            this.idDevis = id;
            this.nomDevis = nom;
            this.dateDevis = date;
            this.quantiteDevis = quantite;
            this.uniteDevis = unite;
            this.prixHTDevis = prixHT;
            this.prixTTDevis = prixTT;
            this.margeCommercialDevis = margeCommercial;
            this.margeEntrepriseDevis = margeEntreprise;
            this.idEtat = id_Etat;
        }
    }
}
