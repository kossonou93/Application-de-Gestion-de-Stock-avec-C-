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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.clientBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dBStockDataSet);

		}

		private void Form2_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dBStockDataSet.Client' table. You can move, or remove it, as needed.
			this.clientTableAdapter.Fill(this.dBStockDataSet.Client);

		}
	}
}
