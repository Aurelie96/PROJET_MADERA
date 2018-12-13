using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Model
{
    public class Client
    {
        #region Propriété privée
        public int idClient;
        public string nomClient;
        public string prenomClient;
        public string adresseClient;
        public string codePostalClient;
        public string villeClient;
        public string emailClient;
        public string faxClient;
        public string mobileClient;
        #endregion

        #region Constructeur
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
        public Client(string nom, string prenom, string adresse,
            string codepostal, string ville, string email, string fax, string mobile)
        {
            this.nomClient = nom;
            this.prenomClient = prenom;
            this.adresseClient = adresse;
            this.codePostalClient = codepostal;
            this.villeClient = ville;
            this.emailClient = email;
            this.faxClient = fax;
            this.mobileClient = mobile;
        }
        public Client(int id)
        {
            this.idClient = id;
        }
        #endregion

        #region Getteur
        public int GetidClient()
        {
            return this.idClient;
        }
        public string GetnomClient()
        {
            return this.nomClient;
        }
        public string GetprenomClient()
        {
            return this.prenomClient;
        }
        public string GetadresseClient()
        {
            return this.adresseClient;
        }
        public string GetcodePostalClient()
        {
            return this.codePostalClient;
        }
        public string GetvilleClient()
        {
            return this.villeClient;
        }
        public string GetemailClient()
        {
            return this.emailClient;
        }
        public string GetfaxClient()
        {
            return this.faxClient;
        }
        public string GetmobileClient()
        {
            return this.mobileClient;
        }
        #endregion
    }
}
