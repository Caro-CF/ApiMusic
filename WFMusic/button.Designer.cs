
namespace WFMusic
{
    partial class button
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
            this.delete = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.SlateBlue;
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(511, 12);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(130, 36);
            this.delete.TabIndex = 15;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.Color.SlateBlue;
            this.details.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.details.Location = new System.Drawing.Point(348, 12);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(130, 36);
            this.details.TabIndex = 14;
            this.details.Text = "Details";
            this.details.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.SlateBlue;
            this.edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.Location = new System.Drawing.Point(186, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(130, 36);
            this.edit.TabIndex = 13;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.SlateBlue;
            this.create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.create.Location = new System.Drawing.Point(19, 12);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(130, 36);
            this.create.TabIndex = 12;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            // 
            // button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.details);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.create);
            this.Name = "button";
            this.Size = new System.Drawing.Size(674, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button create;
    }
}
