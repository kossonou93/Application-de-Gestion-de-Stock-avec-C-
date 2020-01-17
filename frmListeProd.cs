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
	public partial class frmListeProd : Form
	{
		SqlConnection cnx;
		SqlCommand cmd;
		SqlDataAdapter adap;
		SqlCommandBuilder cb;
		DataSet dset;
		DataSet dset2;
		public frmListeProd()
		{
			InitializeComponent();
		}

		private void ProduitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.produitBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dBStockDataSet);

		}

		private void FrmListeProd_Load(object sender, EventArgs e)
		{
			cnx = new SqlConnection();
			cnx.ConnectionString = "Data Source=.;Initial Catalog=DBStock;Integrated Security=True;Pooling=False";
			cnx.Open();
			cmd = new SqlCommand();
			cmd.CommandText = "select * from Fournisseur";
			cmd.Connection = cnx;
			adap = new SqlDataAdapter(cmd);
			dset = new DataSet();
			adap.Fill(dset," Fournisseur");
			DataRow dr;
			dr = dset.Tables[0].NewRow();
			dr["NomPrenom"] = "Toute la liste";
			dset.Tables[0].Rows.Add(dr);
			cmbFourn.DataSource = dset.Tables[0];
			cmbFourn.DisplayMember = "NomPrenom";
			cmbFourn.ValueMember = "CodeFourn";
			cmd = new SqlCommand();
			cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn";
			cmd.Connection = cnx;
			adap = new SqlDataAdapter(cmd);
			dset2 = new DataSet();
			adap.Fill(dset2," Produit");
			dataGridView1.DataSource = dset2.Tables[0];
			cmbFourn.SelectedIndex = cmbFourn.Items.Count - 1;
			// TODO: This line of code loads data into the 'dBStockDataSet.Fournisseur' table. You can move, or remove it, as needed.
			this.fournisseurTableAdapter.Fill(this.dBStockDataSet.Fournisseur);
			// TODO: This line of code loads data into the 'dBStockDataSet.Produit' table. You can move, or remove it, as needed.
			this.produitTableAdapter.Fill(this.dBStockDataSet.Produit);

		}

		private void Label2_Click(object sender, EventArgs e)
		{

		}

		private void CmbFourn_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void BTsupprimer_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Voulez vous vraiment supprimer ce produit?", "Supprimer un Produit", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				try
				{
					cmd.CommandText = "delete from Produit where CodeProduit=" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
					cmd.ExecuteNonQuery();
					MessageBox.Show("suppression effectuée avec succes", " Suppression");
					cmd = new SqlCommand();
					cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn";
					cmd.Connection = cnx;
					adap = new SqlDataAdapter(cmd);
					dset2 = new DataSet();
					adap.Fill(dset2," Produit");
					dataGridView1.DataSource = dset2.Tables[0];
					cmbFourn.SelectedIndex = cmbFourn.Items.Count - 1;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void CmbFourn_SelectionChangeCommitted(object sender, EventArgs e)
		{
			cmd = new SqlCommand();
			if (cmbFourn.SelectedIndex == cmbFourn.Items.Count - 1)
			{
				cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn";
			}
			else
			{
				cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn and P.CodeFourn = " + cmbFourn.SelectedValue;
				cmd.Connection = cnx;
				adap = new SqlDataAdapter(cmd);
				dset2 = new DataSet();
				adap.Fill(dset2, "Produit");
				dataGridView1.DataSource = dset2.Tables[0];
			}

		}
	}
}
