namespace docxParsingUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parcourirModele = new System.Windows.Forms.Button();
            this.sourceModele = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parcourirSourceDonnees = new System.Windows.Forms.Button();
            this.sourceDonnees = new System.Windows.Forms.TextBox();
            this.parcourirDestination = new System.Windows.Forms.Button();
            this.sourceDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boutonGenerer = new System.Windows.Forms.Button();
            this.boutonEffacer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.générerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statut = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.parcourirModele);
            this.groupBox2.Controls.Add(this.sourceModele);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.parcourirSourceDonnees);
            this.groupBox2.Controls.Add(this.sourceDonnees);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sélection des données source et du modèle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modèle :";
            // 
            // parcourirModele
            // 
            this.parcourirModele.Location = new System.Drawing.Point(579, 46);
            this.parcourirModele.Name = "parcourirModele";
            this.parcourirModele.Size = new System.Drawing.Size(68, 20);
            this.parcourirModele.TabIndex = 4;
            this.parcourirModele.Text = "Parcourir";
            this.parcourirModele.UseVisualStyleBackColor = true;
            this.parcourirModele.Click += new System.EventHandler(this.parcourirModele_Click);
            // 
            // sourceModele
            // 
            this.sourceModele.Location = new System.Drawing.Point(135, 46);
            this.sourceModele.Name = "sourceModele";
            this.sourceModele.Size = new System.Drawing.Size(438, 20);
            this.sourceModele.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source des données :";
            // 
            // parcourirSourceDonnees
            // 
            this.parcourirSourceDonnees.Location = new System.Drawing.Point(579, 20);
            this.parcourirSourceDonnees.Name = "parcourirSourceDonnees";
            this.parcourirSourceDonnees.Size = new System.Drawing.Size(68, 20);
            this.parcourirSourceDonnees.TabIndex = 1;
            this.parcourirSourceDonnees.Text = "Parcourir";
            this.parcourirSourceDonnees.UseVisualStyleBackColor = true;
            this.parcourirSourceDonnees.Click += new System.EventHandler(this.parcourirSourceDonnees_Click);
            // 
            // sourceDonnees
            // 
            this.sourceDonnees.Location = new System.Drawing.Point(135, 20);
            this.sourceDonnees.Name = "sourceDonnees";
            this.sourceDonnees.Size = new System.Drawing.Size(438, 20);
            this.sourceDonnees.TabIndex = 0;
            // 
            // parcourirDestination
            // 
            this.parcourirDestination.Location = new System.Drawing.Point(579, 19);
            this.parcourirDestination.Name = "parcourirDestination";
            this.parcourirDestination.Size = new System.Drawing.Size(68, 20);
            this.parcourirDestination.TabIndex = 4;
            this.parcourirDestination.Text = "Parcourir";
            this.parcourirDestination.UseVisualStyleBackColor = true;
            this.parcourirDestination.Click += new System.EventHandler(this.parcourirDestination_Click);
            // 
            // sourceDestination
            // 
            this.sourceDestination.Location = new System.Drawing.Point(135, 19);
            this.sourceDestination.Name = "sourceDestination";
            this.sourceDestination.Size = new System.Drawing.Size(438, 20);
            this.sourceDestination.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sourceDestination);
            this.groupBox3.Controls.Add(this.parcourirDestination);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(653, 54);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sélection de la destination";
            // 
            // boutonGenerer
            // 
            this.boutonGenerer.Location = new System.Drawing.Point(439, 203);
            this.boutonGenerer.Name = "boutonGenerer";
            this.boutonGenerer.Size = new System.Drawing.Size(226, 23);
            this.boutonGenerer.TabIndex = 7;
            this.boutonGenerer.Text = "Générer";
            this.boutonGenerer.UseVisualStyleBackColor = true;
            this.boutonGenerer.Click += new System.EventHandler(this.boutonGenerer_Click);
            // 
            // boutonEffacer
            // 
            this.boutonEffacer.Location = new System.Drawing.Point(187, 203);
            this.boutonEffacer.Name = "boutonEffacer";
            this.boutonEffacer.Size = new System.Drawing.Size(226, 23);
            this.boutonEffacer.TabIndex = 8;
            this.boutonEffacer.Text = "Effacer";
            this.boutonEffacer.UseVisualStyleBackColor = true;
            this.boutonEffacer.Click += new System.EventHandler(this.boutonEffacer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.générerToolStripMenuItem,
            this.effacerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // générerToolStripMenuItem
            // 
            this.générerToolStripMenuItem.Name = "générerToolStripMenuItem";
            this.générerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.générerToolStripMenuItem.Text = "Générer ";
            this.générerToolStripMenuItem.Click += new System.EventHandler(this.générerToolStripMenuItem_Click);
            // 
            // effacerToolStripMenuItem
            // 
            this.effacerToolStripMenuItem.Name = "effacerToolStripMenuItem";
            this.effacerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.effacerToolStripMenuItem.Text = "Effacer";
            this.effacerToolStripMenuItem.Click += new System.EventHandler(this.effacerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statut});
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(674, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statut
            // 
            this.statut.Name = "statut";
            this.statut.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(674, 273);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.boutonEffacer);
            this.Controls.Add(this.boutonGenerer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Générer une LC";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button parcourirDestination;
        private System.Windows.Forms.TextBox sourceDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button parcourirSourceDonnees;
        private System.Windows.Forms.TextBox sourceDonnees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button parcourirModele;
        private System.Windows.Forms.TextBox sourceModele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button boutonGenerer;
        private System.Windows.Forms.Button boutonEffacer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem générerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statut;
    }
}

