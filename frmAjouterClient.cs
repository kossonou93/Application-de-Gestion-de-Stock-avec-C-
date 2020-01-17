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
	public partial class frmAjouterClient : Form
	{
		public frmAjouterClient()
		{
			InitializeComponent();
			
		}

		private void ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.clientBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dBStockDataSet);

		}

		private void FrmAjouterClient_Load(object sender, EventArgs e)
		{
			this.clientTableAdapter.Fill(this.dBStockDataSet.Client);

		}

		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{

		}
	}
}
