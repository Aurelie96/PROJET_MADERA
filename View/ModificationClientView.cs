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
    public partial class ModificationClientView : Form
    {
        public ModificationClientView(object NomClientClick)
        {
            InitializeComponent();
            RemplirInfo(NomClientClick);
        }

        private void RemplirInfo(object NomClientClick)
        {
            Client LeClient;
            LeClient = ClientsDAO.RemplirInfoClient(NomClientClick.ToString());
            TxtReferenceClient.Text = LeClient.GetidClient().ToString();
            TxtNomClient.Text = LeClient.GetnomClient();
            TxtPrenomClient.Text = LeClient.GetprenomClient();
            TxtAdresseClient.Text = LeClient.GetadresseClient();
            TxtCodePostalClient.Text = LeClient.GetcodePostalClient();
            TxtVilleClient.Text = LeClient.GetvilleClient();
            TxtEmailClient.Text = LeClient.GetemailClient();
            txtFaxClient.Text = LeClient.GetfaxClient();
            txtMobileClient.Text = LeClient.GetmobileClient();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Client LeClient = new Client(
                Int32.Parse(TxtReferenceClient.Text),
                TxtNomClient.Text,
                TxtPrenomClient.Text,
                TxtAdresseClient.Text,
                TxtCodePostalClient.Text,
                TxtVilleClient.Text,
                TxtEmailClient.Text,
                txtFaxClient.Text,
                txtMobileClient.Text);
            ClientsDAO.ModifierClient(LeClient);
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Client LeClient = new Client(Int32.Parse(TxtReferenceClient.Text));
            ClientsDAO.SupprimerClient(LeClient);
        }
    }
}
