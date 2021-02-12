
namespace WFMusic
{
    partial class navigation
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.Color.RoyalBlue;
            this.previous.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.previous.Location = new System.Drawing.Point(19, 15);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(95, 23);
            this.previous.TabIndex = 22;
            this.previous.Text = "<< Previous";
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.RoyalBlue;
            this.next.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.next.Location = new System.Drawing.Point(125, 15);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(94, 23);
            this.next.TabIndex = 21;
            this.next.Text = "Next >>";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.button5_Click);
            // 
            // navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Name = "navigation";
            this.Size = new System.Drawing.Size(237, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
    }
}
