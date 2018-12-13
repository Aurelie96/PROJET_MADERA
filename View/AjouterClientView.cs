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
    }
}
