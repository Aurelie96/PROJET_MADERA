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
    public partial class ProjetView : Form
    {
        public ProjetView()
        {
            InitializeComponent();

            List<Projet> LesProjets = ProjetsDAO.ChargerProjet();
            for (int i = 0; i < LesProjets.Count(); i++)
            {
                Console.Write(i);
                dgv_VueProjet.Rows.Add(
                    LesProjets[i].nomProjet,
                    LesProjets[i].dateProjet);
            }
        }
        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            dgv_VueProjet.Rows.Clear();

            List<Projet> LesProjets = ProjetsDAO.ChargerProjet();
            for (int i = 0; i < LesProjets.Count(); i++)
            {
                Console.Write(i);
                dgv_VueProjet.Rows.Add(
                    LesProjets[i].nomProjet,
                    LesProjets[i].dateProjet);
            }
        }

        private void dgv_VueClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object NomProjetClick = dgv_VueProjet.Rows[e.RowIndex].Cells[0].Value;
            ModificationProjetView ModifProjet = new ModificationProjetView(NomProjetClick);
            ModifProjet.Hide();
            ModifProjet.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv_VueProjet.Rows.Clear();
            List<Projet> LeProjet = ProjetsDAO.RechercherProjet(txtRechercherProjet.Text);
            for (int i = 0; i < LeProjet.Count(); i++)
            {
                Console.Write(i);
                dgv_VueProjet.Rows.Add(
                    LeProjet[i].nomProjet,
                    LeProjet[i].dateProjet);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            AjouterProjetView AjoutProjet = new AjouterProjetView();
            AjoutProjet.Hide();
            AjoutProjet.Show();
        }
    }
}
