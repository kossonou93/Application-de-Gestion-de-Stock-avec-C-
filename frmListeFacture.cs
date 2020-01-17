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
	public partial class frmListeFacture : Form
	{
		SqlConnection cnx;
		SqlCommand cmd;
		SqlDataAdapter adap;
		SqlCommandBuilder cb;
		DataSet dset;
		public frmListeFacture()
		{
			InitializeComponent();
		}

		private void CmbClient_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void FrmListeFacture(object sender, EventArgs e)
		{
			cnx = new SqlConnection();
			cnx.ConnectionString = "Data Source=.;Initial Catalog=DBStock;Integrated Security=True;Pooling=False";
			cnx.Open();
			cmd = new SqlCommand();
			cmd.CommandText = "select * from Facture";
			cmd.Connection = cnx;
			adap = new SqlDataAdapter(cmd);
			dset = new DataSet();
			adap.Fill(dset, " Facture");
			dataGridView.DataSource = dset.Tables[0];
		}
	}
}
