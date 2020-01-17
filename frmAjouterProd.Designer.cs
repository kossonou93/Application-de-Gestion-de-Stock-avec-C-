namespace TP6
{
	partial class frmAjouterProd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterProd));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtQt = new System.Windows.Forms.TextBox();
			this.txtPrix = new System.Windows.Forms.TextBox();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.cmbFourn = new System.Windows.Forms.ComboBox();
			this.BTajout = new System.Windows.Forms.Button();
			this.dBStockDataSet = new TP6.DBStockDataSet();
			this.fournisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fournisseurTableAdapter = new TP6.DBStockDataSetTableAdapters.FournisseurTableAdapter();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBStockDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(66, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(635, 64);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(69, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(67, 52);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(256, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ajout d\'un Produit";
			// 
			// txtQt
			// 
			this.txtQt.Location = new System.Drawing.Point(301, 287);
			this.txtQt.Name = "txtQt";
			this.txtQt.Size = new System.Drawing.Size(222, 20);
			this.txtQt.TabIndex = 20;
			this.txtQt.TextChanged += new System.EventHandler(this.TxtQt_TextChanged);
			// 
			// txtPrix
			// 
			this.txtPrix.Location = new System.Drawing.Point(301, 214);
			this.txtPrix.Name = "txtPrix";
			this.txtPrix.Size = new System.Drawing.Size(222, 20);
			this.txtPrix.TabIndex = 18;
			this.txtPrix.TextChanged += new System.EventHandler(this.TxtPrix_TextChanged);
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(301, 181);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(222, 20);
			this.txtNom.TabIndex = 17;
			this.txtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(301, 143);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(222, 20);
			this.txtCode.TabIndex = 16;
			this.txtCode.TextChanged += new System.EventHandler(this.TxtCode_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(152, 291);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 16);
			this.label6.TabIndex = 15;
			this.label6.Text = "Quantité:";
			this.label6.Click += new System.EventHandler(this.Label6_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(152, 253);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Fournisseur:";
			this.label5.Click += new System.EventHandler(this.Label5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(152, 218);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 16);
			this.label4.TabIndex = 13;
			this.label4.Text = "Prix unitaire:";
			this.label4.Click += new System.EventHandler(this.Label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(152, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Nom:";
			this.label3.Click += new System.EventHandler(this.Label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(152, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "Code:";
			this.label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(372, 357);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 32);
			this.button1.TabIndex = 22;
			this.button1.Text = "Quitter";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// cmbFourn
			// 
			this.cmbFourn.DataSource = this.fournisseurBindingSource;
			this.cmbFourn.DisplayMember = "NomPrenom";
			this.cmbFourn.FormattingEnabled = true;
			this.cmbFourn.Location = new System.Drawing.Point(301, 247);
			this.cmbFourn.Name = "cmbFourn";
			this.cmbFourn.Size = new System.Drawing.Size(222, 21);
			this.cmbFourn.TabIndex = 23;
			this.cmbFourn.SelectedIndexChanged += new System.EventHandler(this.CmbFourn_SelectedIndexChanged);
			// 
			// BTajout
			// 
			this.BTajout.Location = new System.Drawing.Point(170, 357);
			this.BTajout.Name = "BTajout";
			this.BTajout.Size = new System.Drawing.Size(100, 32);
			this.BTajout.TabIndex = 24;
			this.BTajout.Text = "Ajouter";
			this.BTajout.UseVisualStyleBackColor = true;
			this.BTajout.Click += new System.EventHandler(this.BTajout_Click);
			// 
			// dBStockDataSet
			// 
			this.dBStockDataSet.DataSetName = "DBStockDataSet";
			this.dBStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			// frmAjouterProd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BTajout);
			this.Controls.Add(this.cmbFourn);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtQt);
			this.Controls.Add(this.txtPrix);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmAjouterProd";
			this.Text = "Ajouter un produit";
			this.Load += new System.EventHandler(this.FrmAjouterProd);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBStockDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtQt;
		private System.Windows.Forms.TextBox txtPrix;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cmbFourn;
		private System.Windows.Forms.Button BTajout;
		private DBStockDataSet dBStockDataSet;
		private System.Windows.Forms.BindingSource fournisseurBindingSource;
		private DBStockDataSetTableAdapters.FournisseurTableAdapter fournisseurTableAdapter;
	}
}