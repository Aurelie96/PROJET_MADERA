using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Madera.Controleur;

namespace Madera.View
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction s'éxécutant à la suite de l'appui sur le bouton "Se connecter"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (CommercialsDAO.ExisteCommercial(tbxIdentifiant.Text, tbxMdp.Text))
            {
                ClientView cv = new ClientView(CommercialsDAO.GetInfosCommercial(tbxIdentifiant.Text, tbxMdp.Text));
                cv.FormClosed += new FormClosedEventHandler(ClientView_FormClosed);
                if(chkRememberMe.Checked)
                {
                    Properties.Settings.Default.username = tbxIdentifiant.Text;
                    Properties.Settings.Default.pwd = tbxMdp.Text;
                    Properties.Settings.Default.Save();
                }
                this.Hide();
                cv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe erronné", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fonction interdisant à l'utilisateur de bouger la fenêtre
        /// </summary>
        /// <param name="message"></param>
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        /// <summary>
        /// Fonction s'éxécutant à la suite de l'appui sur le bouton "X"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.username = tbxIdentifiant.Text;
                Properties.Settings.Default.pwd = tbxMdp.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Reset();
            }
            this.Close();
        }

        /// <summary>
        /// Fonction permettant de réafficher le formulaire appelant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClientView_FormClosed(object sender, FormClosedEventArgs e) => this.Show();

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            if (Madera.Properties.Settings.Default.username != "")
            {
                tbxIdentifiant.Text = Properties.Settings.Default.username;
                tbxMdp.Text = Properties.Settings.Default.pwd;
            }
        }
    }
}
