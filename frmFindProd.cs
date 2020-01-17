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
	public partial class frmFindProd : Form
	{
		SqlConnection cnx;
		SqlCommand cmd;
		SqlDataAdapter adap;
		SqlCommandBuilder cb;
		DataSet dset;

		public frmFindProd()
		{
			InitializeComponent();
		}

		private void FrmFindProd_Load(object sender, EventArgs e)
		{
			cnx = new SqlConnection();
			cnx.ConnectionString = "Data Source=.;Initial Catalog=DBStock;Integrated Security=True;Pooling=False";
			cnx.Open();
			cmd = new SqlCommand();
			cmd.CommandText = "select * from Fournisseur";
			cmd.Connection = cnx;
			adap = new SqlDataAdapter(cmd);
			dset = new DataSet();
			adap.Fill(dset, " Fournisseur");
			DataRow dr;
			dr = dset.Tables[0].NewRow();
			dr["NomPrenom"] = "Toute la liste";
			dset.Tables[0].Rows.Add(dr);
			dataGridView1.DataSource = dset.Tables[0];
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			if (rdbCode.Checked == true)
			{
				cmd = new SqlCommand();
				cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn and CodeProduit like('"+textBox1. Text+"%')";
				cmd.Connection = cnx;
				adap = new SqlDataAdapter(cmd);
				dset = new DataSet();
				adap.Fill(dset, " Produit");
				dataGridView1.DataSource = dset.Tables[0];
			}
			if (rdbNom.Checked == true)
			{
				cmd = new SqlCommand();
				cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn and NomProduit like('"+textBox1. Text+"%')";
				cmd.Connection = cnx;
				adap = new SqlDataAdapter(cmd);
				dset = new DataSet();
				adap.Fill(dset, " Produit");
				dataGridView1.DataSource = dset.Tables[0];
			}
		}

		private void RdbCode_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}

		private void RdbNom_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}
	}
}
