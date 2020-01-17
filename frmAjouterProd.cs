using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TP6
{
	public partial class frmAjouterProd : Form
	{
		SqlConnection cnx;
		SqlCommand cmd;
		SqlDataAdapter adap;
		SqlCommandBuilder cb;
		DataSet dset;
		public frmAjouterProd()
		{
			InitializeComponent();
		}


		private void FrmAjouterProd(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dBStockDataSet.Fournisseur' table. You can move, or remove it, as needed.
			this.fournisseurTableAdapter.Fill(this.dBStockDataSet.Fournisseur);
			cnx = new SqlConnection();
			cnx.ConnectionString = "Data Source=.;Initial Catalog=DBStock;Integrated Security=True;Pooling=False";
			cnx.Open();
			cmd = new SqlCommand();
			cmd.CommandText = "select * from Fournisseur";
			cmd.Connection = cnx;
			adap = new SqlDataAdapter(cmd);
			dset = new DataSet();
			adap.Fill(dset, "Fournisseur");
			cmbFourn.DataSource = dset.Tables[0];
			cmbFourn.DisplayMember = "NomPrenom";
			cmbFourn.ValueMember = "CodeFourn";
		}

		private void BTajout_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Voulez vous vraiment ajouter ce produit ?","Ajout d'un Produit", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				try
				{
					cmd.CommandText = "insert into Produit values" + 
					"(" +
					txtCode.Text + "," + cmbFourn.SelectedValue.ToString() + ",'" +
					txtNom.Text + "','" + txtPrix.Text + "'," + txtQt.Text + ")";
					cmd.ExecuteNonQuery();
					MessageBox.Show("Insertion effectuée avec succes","Insertion");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void CmbFourn_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void TxtCode_TextChanged(object sender, EventArgs e)
		{

		}

		private void Label2_Click(object sender, EventArgs e)
		{

		}

		private void Label3_Click(object sender, EventArgs e)
		{

		}

		private void TxtNom_TextChanged(object sender, EventArgs e)
		{

		}

		private void Label4_Click(object sender, EventArgs e)
		{

		}

		private void TxtPrix_TextChanged(object sender, EventArgs e)
		{

		}

		private void Label5_Click(object sender, EventArgs e)
		{

		}

		private void Label6_Click(object sender, EventArgs e)
		{

		}

		private void TxtQt_TextChanged(object sender, EventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{

		}
	}
}
