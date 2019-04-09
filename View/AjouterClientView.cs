using Madera.Controleur;
using Madera.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madera.View
{
    public partial class AjouterClientView : Form
    {
        public AjouterClientView()
        {
            InitializeComponent();
            TxtNomClient.GotFocus += TxtNomClient_GotFocus; ;
            TxtNomClient.LostFocus += TxtNomClient_LostFocus;
        }

        private void TxtNomClient_GotFocus(object sender, EventArgs e)
        {
            if (TxtNomClient.Text == "Dupond")
                TxtNomClient.Text = "";
            TxtNomClient.ForeColor = Color.Black;
        }

        private void TxtNomClient_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNomClient.Text))
            {
                TxtNomClient.Text = "Dupond";
                TxtNomClient.ForeColor = Color.Gray;
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            Client LeClient = new Client(
                TxtNomClient.Text,
                TxtPrenomClient.Text,
                TxtAdresseClient.Text,
                TxtCodePostalClient.Text,
                TxtVilleClient.Text,
                TxtEmailClient.Text,
                txtFaxClient.Text,
                txtMobileClient.Text);
            ClientsDAO.CreerClient(LeClient);
            ClientsDAO.ChargerClient();
        }

        private void AjouterClientView_Load(object sender, EventArgs e)
        {

        }
    }
}
