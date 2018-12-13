using System;
using System.Collections.Generic;
using System.Text;

using UIPresenter;

namespace UIConsole
{
    public class UIViewer : IViewer
    {
        #region Properties
        private Presenter manager;
        public Presenter Manager
        {
            get { return manager; }
        }
        #endregion

        #region Constructeur
        public UIViewer()
        {
            manager = new Presenter(this);
        }
        #endregion

        #region Public Methodes
        public void Start()
        {
            manager.Start();
        }

        public void CallRequestUserCode()
        {
            loadListTypes(manager.LoadListType());
            Console.Write("Introduisez le code utiliateur:");
            manager.Code = Console.ReadLine();
            manager.CodeInputEnded();
        }
        public void CallRequestUserCode(string message)
        {
            Console.WriteLine(message);
            loadListTypes(manager.LoadListType());
            Console.Write("Introduisez le code utiliateur:");
            manager.Code = Console.ReadLine();
            manager.CodeInputEnded();
        }

        public void CallDisplayUserProfile()
        {
            Console.WriteLine(string.Format("Utilisateur: {0}", manager.Code));
            Console.WriteLine(string.Format("  Nom: {0}", manager.Nom));
            Console.WriteLine(string.Format("  Prénom: {0}", manager.Prenom));
            Console.WriteLine("Appuyez sur ENTER pour quitter");
            Console.ReadLine();
        }
        #endregion

        #region Private Methodes
        private void loadListTypes(List<string> types)
        {
            Console.WriteLine("Tapez le numéro du type choisi:");
            for (int i=0; i<types.Count; i++)
            {
                Console.WriteLine(string.Format("{0} : {1}", i.ToString(), types[i]));
            }
            manager.Type = types[Convert.ToInt32(Console.ReadLine())];
        }
        #endregion
    }
}
