using System;
using System.Collections.Generic;
using System.Text;

using UIPresenter;

namespace UIWindows
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

        #region Constructeurs
            
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

        #endregion

        #region Interface Implementation

            public void CallRequestUserCode()
            {
                CodeRequestForm form = new CodeRequestForm(this);
                form.ShowDialog();
                manager.CodeInputEnded();
            }
        public void CallRequestUserCode(string message)
        {
            CodeRequestForm form = new CodeRequestForm(this);
            form.MessageLable.Text = message;
            form.userCodeTextBox.Text = manager.Code;
            form.typeComboBox.Text = manager.Type;
            form.ShowDialog();
            manager.CodeInputEnded();
        }

            public void CallDisplayUserProfile()
            {
                DisplayInfoForm form = new DisplayInfoForm();
                form.CodeLabel.Text = manager.Code;
                form.NomLabel.Text = manager.Nom;
                form.PrenomLabel.Text = manager.Prenom;
                form.ShowDialog();
            }

        #endregion
    }
}
