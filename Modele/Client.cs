using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Modele
{
    public class Client
    {
        public int idClient { get; set; }
        public string nomClient { get; set; }
        public string prenomClient { get; set; }
        public string adresseClient { get; set; }
        public string codePostalClient { get; set; }
        public string villeClient { get; set; }
        public string emailClient { get; set; }
        public string faxClient { get; set; }
        public string mobileClient { get; set; }
        public Client(int id, string nom, string prenom, string adresse, 
            string codepostal, string ville, string email, string fax, string mobile)
        {
            this.idClient = id;
            this.nomClient = nom;
            this.prenomClient = prenom;
            this.adresseClient = adresse;
            this.codePostalClient = codepostal;
            this.villeClient = ville;
            this.emailClient = email;
            this.faxClient = fax;
            this.mobileClient = mobile;
        }
    }
}
