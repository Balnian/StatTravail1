namespace Travail1
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
            this.RB_Simple = new System.Windows.Forms.RadioButton();
            this.RB_Systematique = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NUD_Taille = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Copie = new System.Windows.Forms.NumericUpDown();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BT_Sortie = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Sortie = new System.Windows.Forms.TextBox();
            this.BT_Source = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Source = new System.Windows.Forms.TextBox();
            this.BT_Executer = new System.Windows.Forms.Button();
            this.BT_Quitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Taille)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Copie)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // RB_Simple
            // 
            this.RB_Simple.AutoSize = true;
            this.RB_Simple.Checked = true;
            this.RB_Simple.Location = new System.Drawing.Point(8, 23);
            this.RB_Simple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB_Simple.Name = "RB_Simple";
            this.RB_Simple.Size = new System.Drawing.Size(131, 21);
            this.RB_Simple.TabIndex = 0;
            this.RB_Simple.TabStop = true;
            this.RB_Simple.Text = "Aléatoire Simple";
            this.RB_Simple.UseVisualStyleBackColor = true;
            // 
            // RB_Systematique
            // 
            this.RB_Systematique.AutoSize = true;
            this.RB_Systematique.Location = new System.Drawing.Point(8, 53);
            this.RB_Systematique.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB_Systematique.Name = "RB_Systematique";
            this.RB_Systematique.Size = new System.Drawing.Size(114, 21);
            this.RB_Systematique.TabIndex = 1;
            this.RB_Systematique.TabStop = true;
            this.RB_Systematique.Text = "Systématique";
            this.RB_Systematique.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Simple);
            this.groupBox1.Controls.Add(this.RB_Systematique);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(168, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de génération";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.NUD_Taille);
            this.groupBox2.Location = new System.Drawing.Point(193, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(169, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Taille de l\'échantillon";
            // 
            // NUD_Taille
            // 
            this.NUD_Taille.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Taille.Location = new System.Drawing.Point(32, 34);
            this.NUD_Taille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUD_Taille.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.NUD_Taille.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Taille.Name = "NUD_Taille";
            this.NUD_Taille.Size = new System.Drawing.Size(109, 22);
            this.NUD_Taille.TabIndex = 0;
            this.NUD_Taille.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.NUD_Copie);
            this.groupBox3.Controls.Add(this.TB_Nom);
            this.groupBox3.Location = new System.Drawing.Point(16, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(347, 95);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nom de sortie et nombre de copie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de copie :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom fichier de sortie :";
            // 
            // NUD_Copie
            // 
            this.NUD_Copie.Location = new System.Drawing.Point(209, 49);
            this.NUD_Copie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUD_Copie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Copie.Name = "NUD_Copie";
            this.NUD_Copie.Size = new System.Drawing.Size(121, 22);
            this.NUD_Copie.TabIndex = 1;
            this.NUD_Copie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(20, 49);
            this.TB_Nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(132, 22);
            this.TB_Nom.TabIndex = 0;
            this.TB_Nom.TextChanged += new System.EventHandler(this.TB_Nom_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BT_Sortie);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TB_Sortie);
            this.groupBox4.Controls.Add(this.BT_Source);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.TB_Source);
            this.groupBox4.Location = new System.Drawing.Point(16, 209);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(347, 162);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Document et Sortie";
            // 
            // BT_Sortie
            // 
            this.BT_Sortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Sortie.Location = new System.Drawing.Point(221, 112);
            this.BT_Sortie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Sortie.Name = "BT_Sortie";
            this.BT_Sortie.Size = new System.Drawing.Size(55, 25);
            this.BT_Sortie.TabIndex = 5;
            this.BT_Sortie.Text = "°°°";
            this.BT_Sortie.UseVisualStyleBackColor = true;
            this.BT_Sortie.Click += new System.EventHandler(this.BT_Sortie_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sortie :";
            // 
            // TB_Sortie
            // 
            this.TB_Sortie.Location = new System.Drawing.Point(20, 112);
            this.TB_Sortie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_Sortie.Name = "TB_Sortie";
            this.TB_Sortie.Size = new System.Drawing.Size(207, 22);
            this.TB_Sortie.TabIndex = 3;
            this.TB_Sortie.TextChanged += new System.EventHandler(this.TB_Sortie_TextChanged);
            // 
            // BT_Source
            // 
            this.BT_Source.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Source.Location = new System.Drawing.Point(221, 53);
            this.BT_Source.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Source.Name = "BT_Source";
            this.BT_Source.Size = new System.Drawing.Size(55, 25);
            this.BT_Source.TabIndex = 2;
            this.BT_Source.Text = "°°°";
            this.BT_Source.UseVisualStyleBackColor = true;
            this.BT_Source.Click += new System.EventHandler(this.BT_Source_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Source :";
            // 
            // TB_Source
            // 
            this.TB_Source.Location = new System.Drawing.Point(20, 53);
            this.TB_Source.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_Source.Name = "TB_Source";
            this.TB_Source.Size = new System.Drawing.Size(207, 22);
            this.TB_Source.TabIndex = 0;
            this.TB_Source.TextChanged += new System.EventHandler(this.TB_Source_TextChanged);
            // 
            // BT_Executer
            // 
            this.BT_Executer.Enabled = false;
            this.BT_Executer.Location = new System.Drawing.Point(144, 398);
            this.BT_Executer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Executer.Name = "BT_Executer";
            this.BT_Executer.Size = new System.Drawing.Size(100, 28);
            this.BT_Executer.TabIndex = 6;
            this.BT_Executer.Text = "Exécuter";
            this.BT_Executer.UseVisualStyleBackColor = true;
            this.BT_Executer.Click += new System.EventHandler(this.BT_Executer_Click);
            // 
            // BT_Quitter
            // 
            this.BT_Quitter.Location = new System.Drawing.Point(253, 396);
            this.BT_Quitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Quitter.Name = "BT_Quitter";
            this.BT_Quitter.Size = new System.Drawing.Size(100, 28);
            this.BT_Quitter.TabIndex = 7;
            this.BT_Quitter.Text = "Quitter";
            this.BT_Quitter.UseVisualStyleBackColor = true;
            this.BT_Quitter.Click += new System.EventHandler(this.BT_Quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 441);
            this.Controls.Add(this.BT_Quitter);
            this.Controls.Add(this.BT_Executer);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Génération";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Taille)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Copie)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RB_Simple;
        private System.Windows.Forms.RadioButton RB_Systematique;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NUD_Taille;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown NUD_Copie;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Source;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Source;
        private System.Windows.Forms.Button BT_Sortie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Sortie;
        private System.Windows.Forms.Button BT_Executer;
        private System.Windows.Forms.Button BT_Quitter;
    }
}

