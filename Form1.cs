using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

		private void AjouterUnClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAjouterClient frmAjouterClt = new frmAjouterClient();
			frmAjouterClt.ShowDialog();
		}

		private void ListesDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.ShowDialog();
		}

		private void AjouterUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAjouterFourn frmAjoutFrn = new frmAjouterFourn();
			frmAjoutFrn.ShowDialog();
		}

		private void ListeDesFournisseursToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form4 frm4 = new Form4();
			frm4.ShowDialog();
		}

		private void AjouterUProduitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAjouterProd frmAjoutPrd = new frmAjouterProd();
			frmAjoutPrd.ShowDialog();
		}

		private void ListeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListeProd frmListePrd = new frmListeProd();
			frmListePrd.ShowDialog();
		}

		private void RechercherUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmFindProd frmFindPrd = new frmFindProd();
			frmFindPrd.ShowDialog();
		}

		private void CréerUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCreerFacture frmCreFact = new frmCreerFacture();
			frmCreFact.ShowDialog();
		}

		private void AfficherFactureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCreerFacture frmCreFact = new frmCreerFacture();
			frmCreFact.ShowDialog();
		}

		private void ListeDesFacturesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmListeFacture frmListefac = new frmListeFacture();
			frmListefac.ShowDialog();
		}
	}
}
