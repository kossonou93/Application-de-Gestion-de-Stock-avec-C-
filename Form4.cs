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
	public partial class Form4 : Form
	{
		SqlConnection cnx;
		SqlCommand cmd;
		SqlDataAdapter adap;
		SqlCommandBuilder cb;
		DataSet dset;
		public Form4()
		{
			InitializeComponent();
		}

		private void FournisseurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.fournisseurBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dBStockDataSet);

		}

		private void Form4_Load(object sender, EventArgs e)
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
			dataGridView1.DataSource = dset.Tables[0];
			// TODO: This line of code loads data into the 'dBStockDataSet.Fournisseur' table. You can move, or remove it, as needed.
			this.fournisseurTableAdapter.Fill(this.dBStockDataSet.Fournisseur);

		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void BTsupprimer1_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Voulez vous vraiment supprimer ce fournisseur?", "Confirmer suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					int i = dataGridView1.CurrentRow.Index;
					dset.Tables[0].Rows[i].Delete();
					cb = new SqlCommandBuilder(adap);
					adap.Update(dset, " Fournisseur");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void BTmodier1_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Voulez vous enregistrer les modifications ? ", "Confirmer modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					cb = new SqlCommandBuilder(adap);
					adap.Update(dset, "Fournisseur");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
