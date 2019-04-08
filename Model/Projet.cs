using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Model
{
    public class Projet
    {
        public int idProjet { get; set; }
        public string nomProjet { get; set; }
        public DateTime dateProjet { get; set; }
        public int idClient { get; set; }
        public int idCommercial { get; set; }
        public int idDevis { get; set; }
        
        public string nomClient { get; set; }
        public string nomCommercial { get; set; }
        public string nomDevis { get; set; }
        public Projet(int id)
        {
            this.idProjet = id;
        }
        public Projet(int id, string nom, DateTime date, string idclient,
            string idcommercial, string iddevis)
        {
            this.idProjet = id;
            this.nomProjet = nom;
            this.dateProjet = date;
            this.nomClient = idclient;
            this.nomCommercial = idcommercial;
            this.nomDevis = iddevis;
        }
        public Projet(int id, string nom, DateTime date, int idclient,
            int idcommercial, int iddevis)
        {
            this.idProjet = id;
            this.nomProjet = nom;
            this.dateProjet = date;
            this.idClient = idclient;
            this.idCommercial = idcommercial;
            this.idDevis = iddevis;
        }
    }
}
