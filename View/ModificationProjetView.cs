<<<<<<< HEAD
﻿using Madera.Controleur;
using Madera.Model;
using System;
=======
﻿using System;
>>>>>>> 998b72d722f998624b54343b4dbe0ab2b7585278
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
<<<<<<< HEAD
        public ModificationProjetView(object NomProjetClick)
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
            RemplirInfo(NomProjetClick);
        }
        private void RemplirInfo(object NomClientClick)
        {
            Projet LeProjet;
            LeProjet = ProjetsDAO.RemplirInfoProjet(NomClientClick.ToString());
            TxtReferenceProjet.Text = LeProjet.idProjet.ToString();
            TxtNomProjet.Text = LeProjet.nomProjet;
            TxtDateProjet.Text = LeProjet.dateProjet.ToString();
            cbxNomClient.Text = LeProjet.nomClient;
            cbxNomCommercial.Text = LeProjet.nomCommercial;
            TxtNomDevis.Text = LeProjet.nomDevis;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Projet LeProjet = new Projet(Int32.Parse(TxtReferenceProjet.Text));
            ProjetsDAO.SupprimerProjet(LeProjet);
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            int client = ClientsDAO.IdClient(cbxNomClient.SelectedItem.ToString());
            int commercial = CommercialsDAO.IdCommercial(cbxNomCommercial.SelectedItem.ToString());
            int devis = DevisDAO.IdDevis(TxtNomDevis.Text);
            Projet LeProjet = new Projet(
                Int32.Parse(TxtReferenceProjet.Text),
                TxtNomProjet.Text,
                DateTime.Parse(TxtDateProjet.Text),
                client,
                commercial,
                devis);
            ProjetsDAO.ModifierProjet(LeProjet);
=======
        public ModificationProjetView()
        {
            InitializeComponent();
>>>>>>> 998b72d722f998624b54343b4dbe0ab2b7585278
        }
    }
}
