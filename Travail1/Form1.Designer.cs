﻿namespace Travail1
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
            this.RB_Simple.Location = new System.Drawing.Point(6, 19);
            this.RB_Simple.Name = "RB_Simple";
            this.RB_Simple.Size = new System.Drawing.Size(100, 17);
            this.RB_Simple.TabIndex = 0;
            this.RB_Simple.TabStop = true;
            this.RB_Simple.Text = "Aléatoire Simple";
            this.RB_Simple.UseVisualStyleBackColor = true;
            // 
            // RB_Systematique
            // 
            this.RB_Systematique.AutoSize = true;
            this.RB_Systematique.Location = new System.Drawing.Point(6, 43);
            this.RB_Systematique.Name = "RB_Systematique";
            this.RB_Systematique.Size = new System.Drawing.Size(88, 17);
            this.RB_Systematique.TabIndex = 1;
            this.RB_Systematique.TabStop = true;
            this.RB_Systematique.Text = "Systématique";
            this.RB_Systematique.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Simple);
            this.groupBox1.Controls.Add(this.RB_Systematique);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de génération";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.NUD_Taille);
            this.groupBox2.Location = new System.Drawing.Point(145, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 67);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Taille de l\'échantillon";
            // 
            // NUD_Taille
            // 
            this.NUD_Taille.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Taille.Location = new System.Drawing.Point(24, 28);
            this.NUD_Taille.Name = "NUD_Taille";
            this.NUD_Taille.Size = new System.Drawing.Size(82, 20);
            this.NUD_Taille.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.NUD_Copie);
            this.groupBox3.Controls.Add(this.TB_Nom);
            this.groupBox3.Location = new System.Drawing.Point(12, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 77);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nom de sortie et nombre de copie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de copie :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom fichier de sortie :";
            // 
            // NUD_Copie
            // 
            this.NUD_Copie.Location = new System.Drawing.Point(157, 40);
            this.NUD_Copie.Name = "NUD_Copie";
            this.NUD_Copie.Size = new System.Drawing.Size(91, 20);
            this.NUD_Copie.TabIndex = 1;
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(15, 40);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(100, 20);
            this.TB_Nom.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BT_Sortie);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TB_Sortie);
            this.groupBox4.Controls.Add(this.BT_Source);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.TB_Source);
            this.groupBox4.Location = new System.Drawing.Point(12, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 132);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Document et Sortie";
            // 
            // BT_Sortie
            // 
            this.BT_Sortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Sortie.Location = new System.Drawing.Point(166, 91);
            this.BT_Sortie.Name = "BT_Sortie";
            this.BT_Sortie.Size = new System.Drawing.Size(41, 20);
            this.BT_Sortie.TabIndex = 5;
            this.BT_Sortie.Text = "°°°";
            this.BT_Sortie.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sortie :";
            // 
            // TB_Sortie
            // 
            this.TB_Sortie.Location = new System.Drawing.Point(15, 91);
            this.TB_Sortie.Name = "TB_Sortie";
            this.TB_Sortie.Size = new System.Drawing.Size(156, 20);
            this.TB_Sortie.TabIndex = 3;
            // 
            // BT_Source
            // 
            this.BT_Source.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Source.Location = new System.Drawing.Point(166, 43);
            this.BT_Source.Name = "BT_Source";
            this.BT_Source.Size = new System.Drawing.Size(41, 20);
            this.BT_Source.TabIndex = 2;
            this.BT_Source.Text = "°°°";
            this.BT_Source.UseVisualStyleBackColor = true;
            this.BT_Source.Click += new System.EventHandler(this.BT_Source_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Source :";
            // 
            // TB_Source
            // 
            this.TB_Source.Location = new System.Drawing.Point(15, 43);
            this.TB_Source.Name = "TB_Source";
            this.TB_Source.Size = new System.Drawing.Size(156, 20);
            this.TB_Source.TabIndex = 0;
            // 
            // BT_Executer
            // 
            this.BT_Executer.Location = new System.Drawing.Point(108, 323);
            this.BT_Executer.Name = "BT_Executer";
            this.BT_Executer.Size = new System.Drawing.Size(75, 23);
            this.BT_Executer.TabIndex = 6;
            this.BT_Executer.Text = "Exécuter";
            this.BT_Executer.UseVisualStyleBackColor = true;
            this.BT_Executer.Click += new System.EventHandler(this.BT_Executer_Click);
            // 
            // BT_Quitter
            // 
            this.BT_Quitter.Location = new System.Drawing.Point(190, 322);
            this.BT_Quitter.Name = "BT_Quitter";
            this.BT_Quitter.Size = new System.Drawing.Size(75, 23);
            this.BT_Quitter.TabIndex = 7;
            this.BT_Quitter.Text = "Quitter";
            this.BT_Quitter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 358);
            this.Controls.Add(this.BT_Quitter);
            this.Controls.Add(this.BT_Executer);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
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

