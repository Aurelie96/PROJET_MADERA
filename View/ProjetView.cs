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
    public partial class ProjetView : Form
    {
        public ProjetView()
        {
            InitializeComponent();
<<<<<<< HEAD
            List<Projet> LeProjet = ProjetsDAO.ChargerProjet();
            for (int i = 0; i < LeProjet.Count(); i++)
            {
                Console.Write(i);
                dgv_VueProjet.Rows.Add(
                    LeProjet[i].nomProjet,
                    LeProjet[i].dateProjet,
                    LeProjet[i].nomClient,
                    LeProjet[i].nomCommercial,
                    LeProjet[i].nomDevis);
            }
        }

        private void txtRechercherClient_TextChanged(object sender, EventArgs e)
        {
            dgv_VueProjet.Rows.Clear();
            List<Projet> LeProjet = ProjetsDAO.RechercherProjet(txtRechercherClient.Text);
            for (int i = 0; i < LeProjet.Count(); i++)
            {
                Console.Write(i);
                dgv_VueProjet.Rows.Add(
                    LeProjet[i].nomProjet,
                    LeProjet[i].dateProjet,
                    LeProjet[i].nomClient,
                    LeProjet[i].nomCommercial,
                    LeProjet[i].nomDevis);
            }
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            dgv_VueProjet.Rows.Clear();

            List<Projet> LeProjet = ProjetsDAO.ChargerProjet();
            for (int i = 0; i < LeProjet.Count(); i++)
            {
                Console.Write(i);
                dgv_VueProjet.Rows.Add(
                    LeProjet[i].nomProjet,
                    LeProjet[i].dateProjet,
                    LeProjet[i].nomClient,
                    LeProjet[i].nomCommercial,
                    LeProjet[i].nomDevis);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            AjouterProjetView AjoutProjet = new AjouterProjetView();
            AjoutProjet.Hide();
            AjoutProjet.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_VueProjet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object NomProjetClick = dgv_VueProjet.Rows[e.RowIndex].Cells[0].Value;
            ModificationProjetView ModifProjet = new ModificationProjetView(NomProjetClick);
            ModifProjet.Hide();
            ModifProjet.Show();
=======
>>>>>>> 998b72d722f998624b54343b4dbe0ab2b7585278
        }
    }
}
