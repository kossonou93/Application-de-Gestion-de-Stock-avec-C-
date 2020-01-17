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
	public partial class frmCreerFacture : Form
	{
		SqlConnection cnx;
		SqlCommand cmd;
		SqlDataAdapter adap;
		SqlCommandBuilder cb;
		DataSet dset;
		public frmCreerFacture()
		{
			InitializeComponent();
		}

		private void FrmCreerFacture_Load(object sender, EventArgs e)
		{
			//this.factureTableAdapter.Fill(this.dBStockDataSet.Client);
			cnx = new SqlConnection();
			cnx.ConnectionString = "Data Source=.;Initial Catalog=DBStock;Integrated Security=True;Pooling=False";
			cnx.Open();
			cmd = new SqlCommand();
			cmd.CommandText = "select * from Client";
			cmd.Connection = cnx;
			adap = new SqlDataAdapter(cmd);
			dset = new DataSet();
			adap.Fill(dset, "Client");
			cmbClient.DataSource = dset.Tables[0];
			cmbClient.DisplayMember = "Nom";
			cmbClient.ValueMember = "CodeClient";
			this.reportViewer1.RefreshReport();
		}

		private void TxtCodeFact_TextChanged(object sender, EventArgs e)
		{

		}

		private void BTajout_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Voulez vous vraiment ajouter cette facture ?", "Création d'une Facture", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				try
				{
					cmd.CommandText = "insert into Facture values" +
					"(" + txtCodeFact.Text + "," + cmbClient.SelectedValue.ToString() + ",'" + dateTime.Value.Date.ToString() + "'," + txtRetenue.Text + ")";
					cmd.ExecuteNonQuery();
					MessageBox.Show("Insertion effectuée avec succes", "Insertion");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
