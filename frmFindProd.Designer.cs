namespace TP6
{
	partial class frmFindProd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindProd));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.rdbCode = new System.Windows.Forms.RadioButton();
			this.rdbNom = new System.Windows.Forms.RadioButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(61, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(635, 73);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(37, 12);
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
			this.label1.Size = new System.Drawing.Size(356, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Rechercher des produits";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(272, 154);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(229, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// rdbCode
			// 
			this.rdbCode.AutoSize = true;
			this.rdbCode.Checked = true;
			this.rdbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbCode.Location = new System.Drawing.Point(249, 205);
			this.rdbCode.Name = "rdbCode";
			this.rdbCode.Size = new System.Drawing.Size(104, 20);
			this.rdbCode.TabIndex = 6;
			this.rdbCode.TabStop = true;
			this.rdbCode.Text = "Code Produit";
			this.rdbCode.UseVisualStyleBackColor = true;
			this.rdbCode.CheckedChanged += new System.EventHandler(this.RdbCode_CheckedChanged);
			// 
			// rdbNom
			// 
			this.rdbNom.AutoSize = true;
			this.rdbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbNom.Location = new System.Drawing.Point(422, 205);
			this.rdbNom.Name = "rdbNom";
			this.rdbNom.Size = new System.Drawing.Size(100, 20);
			this.rdbNom.TabIndex = 7;
			this.rdbNom.Text = "Nom Produit";
			this.rdbNom.UseVisualStyleBackColor = true;
			this.rdbNom.CheckedChanged += new System.EventHandler(this.RdbNom_CheckedChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(61, 266);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(612, 173);
			this.dataGridView1.TabIndex = 8;
			// 
			// frmFindProd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 518);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.rdbNom);
			this.Controls.Add(this.rdbCode);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmFindProd";
			this.Text = "Rechercher un produit";
			this.Load += new System.EventHandler(this.FrmFindProd_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton rdbCode;
		private System.Windows.Forms.RadioButton rdbNom;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}