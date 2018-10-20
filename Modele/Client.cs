using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Modele
{
    class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public Client(int id, string nom, string prenom, string adresse, 
            string codepostal, string ville, string email, string fax, string mobile)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
            this.CodePostal = codepostal;
            this.Ville = ville;
            this.Email = email;
            this.Fax = fax;
            this.Mobile = mobile;
        }
    }
}
