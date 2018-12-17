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

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (CommercialsDAO.ExisteCommercial(tbxIdentifiant.Text, tbxMdp.Text))
            {
                ClientView cv = new ClientView(CommercialsDAO.GetInfosCommercial(tbxIdentifiant.Text, tbxMdp.Text));
                cv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe erronné", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
