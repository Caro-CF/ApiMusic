
namespace WFMusic
{
    partial class Formulaire
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
            this.tbRating = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbReleaseDate = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.cbValidate = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(109, 258);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(221, 22);
            this.tbRating.TabIndex = 32;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(107, 212);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(221, 22);
            this.tbPrice.TabIndex = 31;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(109, 164);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(221, 22);
            this.tbGenre.TabIndex = 30;
            // 
            // tbReleaseDate
            // 
            this.tbReleaseDate.Location = new System.Drawing.Point(164, 113);
            this.tbReleaseDate.Name = "tbReleaseDate";
            this.tbReleaseDate.Size = new System.Drawing.Size(221, 22);
            this.tbReleaseDate.TabIndex = 29;
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(98, 67);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(221, 22);
            this.tbArtist.TabIndex = 28;
            this.tbArtist.TextChanged += new System.EventHandler(this.tbArtist_TextChanged);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(98, 21);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(221, 22);
            this.tbTitle.TabIndex = 27;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // cbValidate
            // 
            this.cbValidate.AutoSize = true;
            this.cbValidate.Location = new System.Drawing.Point(136, 300);
            this.cbValidate.Name = "cbValidate";
            this.cbValidate.Size = new System.Drawing.Size(98, 21);
            this.cbValidate.TabIndex = 26;
            this.cbValidate.Text = "checkBox1";
            this.cbValidate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(28, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "IsValidate :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(28, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Rating :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(28, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Genre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Release date  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Artist :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Title :";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.SlateBlue;
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(525, 351);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(130, 36);
            this.delete.TabIndex = 36;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.Color.SlateBlue;
            this.details.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.details.Location = new System.Drawing.Point(362, 351);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(130, 36);
            this.details.TabIndex = 35;
            this.details.Text = "Details";
            this.details.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.SlateBlue;
            this.edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.Location = new System.Drawing.Point(200, 351);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(130, 36);
            this.edit.TabIndex = 34;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.SlateBlue;
            this.create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.create.Location = new System.Drawing.Point(33, 351);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(130, 36);
            this.create.TabIndex = 33;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.details);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.create);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbReleaseDate);
            this.Controls.Add(this.tbArtist);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.cbValidate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Formulaire";
            this.Size = new System.Drawing.Size(672, 418);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbReleaseDate;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.CheckBox cbValidate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button create;
    }
}
