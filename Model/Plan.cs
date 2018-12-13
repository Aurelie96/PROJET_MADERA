using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Model
{
    public class Plan
    {
        public int idPlan { get; set; }
        public string nomPlan { get; set; }
        public DateTime datePlan { get; set; }
        public int idProjet { get; set; }
        public int idModule { get; set; }
        public int idSol { get; set; }
        public int idCouverture { get; set; }
        public int idForme { get; set; }
        public int idGamme { get; set; }

        public Plan(int id, string nom, DateTime date, int idprojet,
            int idmodule, int idsol, int idcouverture, int idforme, int idgamme)
        {
            this.idPlan = id;
            this.nomPlan = nom;
            this.datePlan = date;
            this.idProjet = idprojet;
            this.idModule = idmodule;
            this.idSol = idsol;
            this.idCouverture = idcouverture;
            this.idForme = idforme;
            this.idGamme = idgamme;
        }
    }
}
