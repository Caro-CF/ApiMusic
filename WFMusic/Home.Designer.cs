﻿
namespace WFMusic
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.formulaire1 = new WFMusic.Formulaire();
            this.button1 = new WFMusic.button();
            this.navigation1 = new WFMusic.navigation();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formulaire1
            // 
            this.formulaire1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.formulaire1.Location = new System.Drawing.Point(57, 60);
            this.formulaire1.Name = "formulaire1";
            this.formulaire1.Size = new System.Drawing.Size(472, 351);
            this.formulaire1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(45, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(674, 64);
            this.button1.TabIndex = 22;
            // 
            // navigation1
            // 
            this.navigation1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.navigation1.Location = new System.Drawing.Point(472, 342);
            this.navigation1.Name = "navigation1";
            this.navigation1.Size = new System.Drawing.Size(237, 49);
            this.navigation1.TabIndex = 23;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(767, 523);
            this.Controls.Add(this.navigation1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.formulaire1);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Formulaire formulaire1;
        private button button1;
        private navigation navigation1;
    }
}
