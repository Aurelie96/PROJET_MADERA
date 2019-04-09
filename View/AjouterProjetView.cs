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
    public partial class AjouterProjetView : Form
    {
        public AjouterProjetView()
        {
            InitializeComponent();
            List<Client> LesClients = ClientsDAO.ChargerClient();
            for (int i = 0; i < LesClients.Count(); i++)
            {
                Console.Write(i);
                cbxNomClient.Items.Add(LesClients[i].nomClient);
            }
            List<Commercial> LesCommercials = CommercialsDAO.chargerCommercial();
            for (int i = 0; i < LesCommercials.Count(); i++)
            {
                Console.Write(i);
                cbxNomCommercial.Items.Add(LesCommercials[i].nomCommercial);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            int client = ClientsDAO.IdClient(cbxNomClient.SelectedItem.ToString());
            int commercial = CommercialsDAO.IdCommercial(cbxNomCommercial.SelectedItem.ToString());
            Projet LeProjet = new Projet(
                TxtNomProjet.Text,
                cbxNomClient.SelectedItem.ToString(),
                client,
                commercial);
            ProjetsDAO.CreerProjet(LeProjet);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
