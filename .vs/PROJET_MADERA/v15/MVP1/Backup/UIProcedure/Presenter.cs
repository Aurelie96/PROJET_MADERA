using System;
using System.Collections.Generic;
using System.Text;

namespace UIPresenter
{
    public class Presenter
    {

    #region Properies
        
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

    #endregion

    #region fields

        private IViewer viewer;

    #endregion

    #region Constructeur

        public Presenter(IViewer callerInstance)
        {
            viewer = callerInstance;
        }

    #endregion

    #region Public Methodes
        public void Start()
        {
            viewer.CallRequestUserCode();
        }

        public List<string> LoadListType()
        {
            List<string> types = new List<string>();
            types.Add("Local");
            types.Add("Domaine");
            return types;
        }

        public bool Validate()
        {
            return (code.Length > 2);
        }

        public void CodeInputEnded()
        {
            if (Validate())
            {
                loadProfile(code);
                viewer.CallDisplayUserProfile();
            }
            else
            {
                viewer.CallRequestUserCode("Données non valides");
            }
        }

    #endregion

    #region Private Methodes

        private void loadProfile(string code)
        {
            // TODO call business service
            nom = "Son nom";
            prenom = "Son prénom";
        }

    #endregion
    }
}
