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
    public partial class ModificationProjetView : Form
    {
        public ModificationProjetView(object NomProjetClick)
        {
            InitializeComponent();
            List<Client> LesClients = ClientsDAO.ChargerClient();
            for (int i = 0; i < LesClients.Count(); i++)
            {
                Console.Write(i);
                cbxNomClient.Items.Add(LesClients[i].nomClient);
            }
            List<Commercial> LesCommercial = CommercialsDAO.chargerCommercial();
            for (int i = 0; i < LesCommercial.Count(); i++)
            {
                Console.Write(i);
                cbxNomCommercial.Items.Add(LesCommercial[i].nomCommercial);
            }
            RemplirInfo(NomProjetClick);
        }

        private void RemplirInfo(object NomProjetClick)
        {
            Projet LeProjet;
            LeProjet = ProjetsDAO.RemplirInfoProjet(NomProjetClick.ToString());
            TxtReferenceProjet.Text = LeProjet.idProjet.ToString();
            TxtNomProjet.Text = LeProjet.nomProjet;
            TxtDateProjet.Text = LeProjet.dateProjet.ToLongDateString();
            cbxNomClient.Text = LeProjet.nomClient;
            cbxNomCommercial.Text = LeProjet.nomCommercial;
            lblNomDevis.Text = LeProjet.nomDevis;
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Projet LeProjet = new Projet(
                Int32.Parse(TxtReferenceProjet.Text),
                TxtNomProjet.Text,
                DateTime.Parse(TxtDateProjet.Text),
                cbxNomClient.Text,
                cbxNomCommercial.Text,
                lblNomDevis.Text);
            ProjetsDAO.ModifierProjet(LeProjet);
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Projet LeProjet = new Projet(Int32.Parse(TxtReferenceProjet.Text));
            ProjetsDAO.SupprimerProjet(LeProjet);
        }
    }
}
