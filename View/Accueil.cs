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
    public partial class Accueil : Form
    {
        public Accueil(string infos)
        {
            InitializeComponent();
            lblBienvenue.Text += infos;
        }

        private void btnLesClients_Click(object sender, EventArgs e)
        {
            ClientView Client = new ClientView();
            Client.Hide();
            Client.Show();
        }

        private void btnLesProjets_Click(object sender, EventArgs e)
        {
            ProjetView Projet = new ProjetView();
            Projet.Hide();
            Projet.Show();
        }

        private void btnLesDevis_Click(object sender, EventArgs e)
        {
            DevisView Devis = new DevisView();
            Devis.Hide();
            Devis.Show();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            MonProfilView MonProfil = new MonProfilView();
            MonProfil.Hide();
            MonProfil.Show();
        }

        private void btnLesPlans_Click(object sender, EventArgs e)
        {
            PlanView Plan = new PlanView();
            Plan.Hide();
            Plan.Show();
        }
    }
}
