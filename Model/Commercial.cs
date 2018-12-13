using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Model
{
    public class Commercial
    {
        public int idCommercial { get; set; }
        public string nomCommercial { get; set; }
        public string prenomCommercial { get; set; }
        public string loginCommercial { get; set; }
        public string motDePasseCommercial { get; set; }
        public Commercial(int id, string nom, string prenom, string login, string password)
        {
            this.idCommercial = id;
            this.nomCommercial = nom;
            this.prenomCommercial = prenom;
            this.loginCommercial = login;
            this.motDePasseCommercial = password;
        }
    }
}
