using Madera.Controleur;
using Madera.Data;
using Madera.Model;
using Madera.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madera
{
    public partial class ClientView : Form
    {
        public ClientView(string infos)
        {
            InitializeComponent();
            List<Client> LesClients = ClientsDAO.ChargerClient();
            for (int i = 0; i < LesClients.Count(); i++)
            {
                Console.Write(i);
                dgv_VueClient.Rows.Add(
                    LesClients[i].GetnomClient(),
                    LesClients[i].GetprenomClient(),
                    LesClients[i].GetadresseClient(),
                    LesClients[i].GetcodePostalClient(),
                    LesClients[i].GetvilleClient(),
                    LesClients[i].GetemailClient(),
                    LesClients[i].GetfaxClient(),
                    LesClients[i].GetmobileClient());
            }
            lblBienvenue.Text += infos;
        }
        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            dgv_VueClient.Rows.Clear();

            List<Client> LesClients = ClientsDAO.ChargerClient();
            for (int i = 0; i < LesClients.Count(); i++)
            {
                Console.Write(i);
                dgv_VueClient.Rows.Add(
                    LesClients[i].GetnomClient(),
                    LesClients[i].GetprenomClient(),
                    LesClients[i].GetadresseClient(),
                    LesClients[i].GetcodePostalClient(),
                    LesClients[i].GetvilleClient(),
                    LesClients[i].GetemailClient(),
                    LesClients[i].GetfaxClient(),
                    LesClients[i].GetmobileClient());
            }
        }

        private void dgv_VueClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object NomClientClick = dgv_VueClient.Rows[e.RowIndex].Cells[0].Value;
            ModificationClientView ModifClient = new ModificationClientView(NomClientClick);
            ModifClient.Hide();
            ModifClient.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv_VueClient.Rows.Clear();
            List<Client> LeClient = ClientsDAO.RechercherClient(txtRechercherClient.Text);
            for(int i = 0; i < LeClient.Count(); i++)
            {
                Console.Write(i);
                dgv_VueClient.Rows.Add(
                    LeClient[i].GetnomClient(),
                    LeClient[i].GetprenomClient(),
                    LeClient[i].GetadresseClient(),
                    LeClient[i].GetcodePostalClient(),
                    LeClient[i].GetvilleClient(),
                    LeClient[i].GetemailClient(),
                    LeClient[i].GetfaxClient(),
                    LeClient[i].GetmobileClient());
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            AjouterClientView AjoutClient = new AjouterClientView();
            AjoutClient.Hide();
            AjoutClient.Show();
        }
    }
}
