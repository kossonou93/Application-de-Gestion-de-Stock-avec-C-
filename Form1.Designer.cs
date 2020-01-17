namespace TP6
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajouterUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listesDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajouterUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listeDesFournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajouterUProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listeDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rechercherUnProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.creerFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afficherFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listeDesFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.fournisseursToolStripMenuItem,
            this.produitsToolStripMenuItem,
            this.facturesToolStripMenuItem,
            this.toolStripMenuItem1});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// clientsToolStripMenuItem
			// 
			this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnClientToolStripMenuItem,
            this.listesDesClientsToolStripMenuItem});
			this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
			resources.ApplyResources(this.clientsToolStripMenuItem, "clientsToolStripMenuItem");
			// 
			// ajouterUnClientToolStripMenuItem
			// 
			resources.ApplyResources(this.ajouterUnClientToolStripMenuItem, "ajouterUnClientToolStripMenuItem");
			this.ajouterUnClientToolStripMenuItem.Name = "ajouterUnClientToolStripMenuItem";
			this.ajouterUnClientToolStripMenuItem.Click += new System.EventHandler(this.AjouterUnClientToolStripMenuItem_Click);
			// 
			// listesDesClientsToolStripMenuItem
			// 
			resources.ApplyResources(this.listesDesClientsToolStripMenuItem, "listesDesClientsToolStripMenuItem");
			this.listesDesClientsToolStripMenuItem.Name = "listesDesClientsToolStripMenuItem";
			this.listesDesClientsToolStripMenuItem.Click += new System.EventHandler(this.ListesDesClientsToolStripMenuItem_Click);
			// 
			// fournisseursToolStripMenuItem
			// 
			this.fournisseursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnFournisseurToolStripMenuItem,
            this.listeDesFournisseursToolStripMenuItem});
			this.fournisseursToolStripMenuItem.Name = "fournisseursToolStripMenuItem";
			resources.ApplyResources(this.fournisseursToolStripMenuItem, "fournisseursToolStripMenuItem");
			// 
			// ajouterUnFournisseurToolStripMenuItem
			// 
			resources.ApplyResources(this.ajouterUnFournisseurToolStripMenuItem, "ajouterUnFournisseurToolStripMenuItem");
			this.ajouterUnFournisseurToolStripMenuItem.Name = "ajouterUnFournisseurToolStripMenuItem";
			this.ajouterUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.AjouterUnFournisseurToolStripMenuItem_Click);
			// 
			// listeDesFournisseursToolStripMenuItem
			// 
			resources.ApplyResources(this.listeDesFournisseursToolStripMenuItem, "listeDesFournisseursToolStripMenuItem");
			this.listeDesFournisseursToolStripMenuItem.Name = "listeDesFournisseursToolStripMenuItem";
			this.listeDesFournisseursToolStripMenuItem.Click += new System.EventHandler(this.ListeDesFournisseursToolStripMenuItem_Click);
			// 
			// produitsToolStripMenuItem
			// 
			this.produitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUProduitToolStripMenuItem,
            this.listeDesProduitsToolStripMenuItem,
            this.rechercherUnProduitToolStripMenuItem});
			this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
			resources.ApplyResources(this.produitsToolStripMenuItem, "produitsToolStripMenuItem");
			// 
			// ajouterUProduitToolStripMenuItem
			// 
			resources.ApplyResources(this.ajouterUProduitToolStripMenuItem, "ajouterUProduitToolStripMenuItem");
			this.ajouterUProduitToolStripMenuItem.Name = "ajouterUProduitToolStripMenuItem";
			this.ajouterUProduitToolStripMenuItem.Click += new System.EventHandler(this.AjouterUProduitToolStripMenuItem_Click);
			// 
			// listeDesProduitsToolStripMenuItem
			// 
			resources.ApplyResources(this.listeDesProduitsToolStripMenuItem, "listeDesProduitsToolStripMenuItem");
			this.listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
			this.listeDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.ListeDesProduitsToolStripMenuItem_Click);
			// 
			// rechercherUnProduitToolStripMenuItem
			// 
			resources.ApplyResources(this.rechercherUnProduitToolStripMenuItem, "rechercherUnProduitToolStripMenuItem");
			this.rechercherUnProduitToolStripMenuItem.Name = "rechercherUnProduitToolStripMenuItem";
			this.rechercherUnProduitToolStripMenuItem.Click += new System.EventHandler(this.RechercherUnProduitToolStripMenuItem_Click);
			// 
			// facturesToolStripMenuItem
			// 
			this.facturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerFactureToolStripMenuItem,
            this.afficherFactureToolStripMenuItem,
            this.listeDesFacturesToolStripMenuItem});
			this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
			resources.ApplyResources(this.facturesToolStripMenuItem, "facturesToolStripMenuItem");
			// 
			// creerFactureToolStripMenuItem
			// 
			resources.ApplyResources(this.creerFactureToolStripMenuItem, "creerFactureToolStripMenuItem");
			this.creerFactureToolStripMenuItem.Name = "creerFactureToolStripMenuItem";
			this.creerFactureToolStripMenuItem.Click += new System.EventHandler(this.CréerUneFactureToolStripMenuItem_Click);
			// 
			// afficherFactureToolStripMenuItem
			// 
			resources.ApplyResources(this.afficherFactureToolStripMenuItem, "afficherFactureToolStripMenuItem");
			this.afficherFactureToolStripMenuItem.Name = "afficherFactureToolStripMenuItem";
			this.afficherFactureToolStripMenuItem.Click += new System.EventHandler(this.AfficherFactureToolStripMenuItem_Click);
			// 
			// listeDesFacturesToolStripMenuItem
			// 
			resources.ApplyResources(this.listeDesFacturesToolStripMenuItem, "listeDesFacturesToolStripMenuItem");
			this.listeDesFacturesToolStripMenuItem.Name = "listeDesFacturesToolStripMenuItem";
			this.listeDesFacturesToolStripMenuItem.Click += new System.EventHandler(this.ListeDesFacturesToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.Black;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesFournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherUnProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesFacturesToolStripMenuItem;
    }
}

