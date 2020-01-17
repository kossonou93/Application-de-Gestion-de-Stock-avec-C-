namespace TP6
{
	partial class frmCreerFacture
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreerFacture));
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BTajout = new System.Windows.Forms.Button();
			this.BTquitter = new System.Windows.Forms.Button();
			this.txtRetenue = new System.Windows.Forms.TextBox();
			this.txtCodeFact = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbClient = new System.Windows.Forms.ComboBox();
			this.dateTime = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Location = new System.Drawing.Point(48, 92);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(698, 271);
			this.reportViewer1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(71, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(635, 64);
			this.groupBox1.TabIndex = 4;
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
			this.label1.Location = new System.Drawing.Point(261, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Créer Facture";
			// 
			// BTajout
			// 
			this.BTajout.Location = new System.Drawing.Point(236, 390);
			this.BTajout.Name = "BTajout";
			this.BTajout.Size = new System.Drawing.Size(100, 32);
			this.BTajout.TabIndex = 35;
			this.BTajout.Text = "Ajouter";
			this.BTajout.UseVisualStyleBackColor = true;
			this.BTajout.Click += new System.EventHandler(this.BTajout_Click);
			// 
			// BTquitter
			// 
			this.BTquitter.Location = new System.Drawing.Point(486, 390);
			this.BTquitter.Name = "BTquitter";
			this.BTquitter.Size = new System.Drawing.Size(100, 32);
			this.BTquitter.TabIndex = 34;
			this.BTquitter.Text = "Quitter";
			this.BTquitter.UseVisualStyleBackColor = true;
			// 
			// txtRetenue
			// 
			this.txtRetenue.Location = new System.Drawing.Point(364, 302);
			this.txtRetenue.Name = "txtRetenue";
			this.txtRetenue.Size = new System.Drawing.Size(222, 20);
			this.txtRetenue.TabIndex = 33;
			// 
			// txtCodeFact
			// 
			this.txtCodeFact.Location = new System.Drawing.Point(364, 158);
			this.txtCodeFact.Name = "txtCodeFact";
			this.txtCodeFact.Size = new System.Drawing.Size(222, 20);
			this.txtCodeFact.TabIndex = 30;
			this.txtCodeFact.TextChanged += new System.EventHandler(this.TxtCodeFact_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(215, 303);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 16);
			this.label6.TabIndex = 29;
			this.label6.Text = "Retenue:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(215, 262);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 16);
			this.label4.TabIndex = 27;
			this.label4.Text = "Date Facture:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(215, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 16);
			this.label3.TabIndex = 26;
			this.label3.Text = "Code Client:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(215, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 16);
			this.label2.TabIndex = 25;
			this.label2.Text = "Code Facture:";
			// 
			// cmbClient
			// 
			this.cmbClient.DisplayMember = "NomPrenom";
			this.cmbClient.FormattingEnabled = true;
			this.cmbClient.Location = new System.Drawing.Point(364, 209);
			this.cmbClient.Name = "cmbClient";
			this.cmbClient.Size = new System.Drawing.Size(222, 21);
			this.cmbClient.TabIndex = 36;
			// 
			// dateTime
			// 
			this.dateTime.Location = new System.Drawing.Point(364, 258);
			this.dateTime.Name = "dateTime";
			this.dateTime.Size = new System.Drawing.Size(222, 20);
			this.dateTime.TabIndex = 37;
			// 
			// frmCreerFacture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dateTime);
			this.Controls.Add(this.cmbClient);
			this.Controls.Add(this.BTajout);
			this.Controls.Add(this.BTquitter);
			this.Controls.Add(this.txtRetenue);
			this.Controls.Add(this.txtCodeFact);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.reportViewer1);
			this.Name = "frmCreerFacture";
			this.Text = "Créer Facture";
			this.Load += new System.EventHandler(this.FrmCreerFacture_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BTajout;
		private System.Windows.Forms.Button BTquitter;
		private System.Windows.Forms.TextBox txtRetenue;
		private System.Windows.Forms.TextBox txtCodeFact;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbClient;
		private System.Windows.Forms.DateTimePicker dateTime;
	}
}