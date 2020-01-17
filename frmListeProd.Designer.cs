namespace TP6
{
	partial class frmListeProd
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeProd));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbFourn = new System.Windows.Forms.ComboBox();
			this.dBStockDataSet = new TP6.DBStockDataSet();
			this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.produitTableAdapter = new TP6.DBStockDataSetTableAdapters.ProduitTableAdapter();
			this.tableAdapterManager = new TP6.DBStockDataSetTableAdapters.TableAdapterManager();
			this.produitBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.produitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BTsupprimer = new System.Windows.Forms.Button();
			this.BTmodifier = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.produitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.fournisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fournisseurTableAdapter = new TP6.DBStockDataSetTableAdapters.FournisseurTableAdapter();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBStockDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produitBindingNavigator)).BeginInit();
			this.produitBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produitBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(83, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(635, 111);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(46, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(103, 92);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(256, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Liste des produits";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(184, 150);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Fournisseur:";
			this.label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// cmbFourn
			// 
			this.cmbFourn.DataSource = this.fournisseurBindingSource;
			this.cmbFourn.DisplayMember = "NomPrenom";
			this.cmbFourn.FormattingEnabled = true;
			this.cmbFourn.Location = new System.Drawing.Point(317, 145);
			this.cmbFourn.Name = "cmbFourn";
			this.cmbFourn.Size = new System.Drawing.Size(223, 21);
			this.cmbFourn.TabIndex = 5;
			this.cmbFourn.SelectedIndexChanged += new System.EventHandler(this.CmbFourn_SelectedIndexChanged);
			this.cmbFourn.SelectionChangeCommitted += new System.EventHandler(this.CmbFourn_SelectionChangeCommitted);
			// 
			// dBStockDataSet
			// 
			this.dBStockDataSet.DataSetName = "DBStockDataSet";
			this.dBStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// produitBindingSource
			// 
			this.produitBindingSource.DataMember = "Produit";
			this.produitBindingSource.DataSource = this.dBStockDataSet;
			// 
			// produitTableAdapter
			// 
			this.produitTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.ClientTableAdapter = null;
			this.tableAdapterManager.FactureTableAdapter = null;
			this.tableAdapterManager.FournisseurTableAdapter = this.fournisseurTableAdapter;
			this.tableAdapterManager.LigneFactureTableAdapter = null;
			this.tableAdapterManager.ProduitTableAdapter = this.produitTableAdapter;
			this.tableAdapterManager.UpdateOrder = TP6.DBStockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// produitBindingNavigator
			// 
			this.produitBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.produitBindingNavigator.BindingSource = this.produitBindingSource;
			this.produitBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.produitBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.produitBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.produitBindingNavigatorSaveItem});
			this.produitBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.produitBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.produitBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.produitBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.produitBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.produitBindingNavigator.Name = "produitBindingNavigator";
			this.produitBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.produitBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.produitBindingNavigator.TabIndex = 6;
			this.produitBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// produitBindingNavigatorSaveItem
			// 
			this.produitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.produitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produitBindingNavigatorSaveItem.Image")));
			this.produitBindingNavigatorSaveItem.Name = "produitBindingNavigatorSaveItem";
			this.produitBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.produitBindingNavigatorSaveItem.Text = "Save Data";
			this.produitBindingNavigatorSaveItem.Click += new System.EventHandler(this.ProduitBindingNavigatorSaveItem_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.dataGridView1.DataSource = this.produitBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(116, 189);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(543, 229);
			this.dataGridView1.TabIndex = 6;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "CodeProduit";
			this.dataGridViewTextBoxColumn1.HeaderText = "CodeProduit";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "CodeFourn";
			this.dataGridViewTextBoxColumn2.HeaderText = "CodeFourn";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "NomProduit";
			this.dataGridViewTextBoxColumn3.HeaderText = "NomProduit";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "PrixUnitaire";
			this.dataGridViewTextBoxColumn4.HeaderText = "PrixUnitaire";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "QtEnStock";
			this.dataGridViewTextBoxColumn5.HeaderText = "QtEnStock";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// BTsupprimer
			// 
			this.BTsupprimer.Location = new System.Drawing.Point(83, 433);
			this.BTsupprimer.Name = "BTsupprimer";
			this.BTsupprimer.Size = new System.Drawing.Size(136, 32);
			this.BTsupprimer.TabIndex = 25;
			this.BTsupprimer.Text = "Supprimer";
			this.BTsupprimer.UseVisualStyleBackColor = true;
			this.BTsupprimer.Click += new System.EventHandler(this.BTsupprimer_Click);
			// 
			// BTmodifier
			// 
			this.BTmodifier.Location = new System.Drawing.Point(317, 433);
			this.BTmodifier.Name = "BTmodifier";
			this.BTmodifier.Size = new System.Drawing.Size(125, 32);
			this.BTmodifier.TabIndex = 26;
			this.BTmodifier.Text = "Modifier";
			this.BTmodifier.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(564, 433);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 32);
			this.button2.TabIndex = 27;
			this.button2.Text = "Quitter";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// produitBindingSource1
			// 
			this.produitBindingSource1.DataMember = "Produit";
			this.produitBindingSource1.DataSource = this.dBStockDataSet;
			// 
			// fournisseurBindingSource
			// 
			this.fournisseurBindingSource.DataMember = "Fournisseur";
			this.fournisseurBindingSource.DataSource = this.dBStockDataSet;
			// 
			// fournisseurTableAdapter
			// 
			this.fournisseurTableAdapter.ClearBeforeFill = true;
			// 
			// frmListeProd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 491);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.BTmodifier);
			this.Controls.Add(this.BTsupprimer);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.produitBindingNavigator);
			this.Controls.Add(this.cmbFourn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmListeProd";
			this.Text = "Liste des produits";
			this.Load += new System.EventHandler(this.FrmListeProd_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBStockDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produitBindingNavigator)).EndInit();
			this.produitBindingNavigator.ResumeLayout(false);
			this.produitBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produitBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbFourn;
		private DBStockDataSet dBStockDataSet;
		private System.Windows.Forms.BindingSource produitBindingSource;
		private DBStockDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
		private DBStockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator produitBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton produitBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.BindingSource produitBindingSource1;
		private DBStockDataSetTableAdapters.FournisseurTableAdapter fournisseurTableAdapter;
		private System.Windows.Forms.Button BTsupprimer;
		private System.Windows.Forms.Button BTmodifier;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.BindingSource fournisseurBindingSource;
	}
}