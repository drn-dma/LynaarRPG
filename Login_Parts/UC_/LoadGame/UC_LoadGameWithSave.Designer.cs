namespace Lynaar_GUI.Login_Parts.UC_.LoadGame
{
    partial class UC_LoadGameWithSave
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
            this.picBox_ClasseIcon = new System.Windows.Forms.PictureBox();
            this.lbl_Pseudo = new System.Windows.Forms.Label();
            this.lbl_Niveaux = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ClasseIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_ClasseIcon
            // 
            this.picBox_ClasseIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_ClasseIcon.Location = new System.Drawing.Point(15, 3);
            this.picBox_ClasseIcon.Name = "picBox_ClasseIcon";
            this.picBox_ClasseIcon.Size = new System.Drawing.Size(44, 44);
            this.picBox_ClasseIcon.TabIndex = 0;
            this.picBox_ClasseIcon.TabStop = false;
            // 
            // lbl_Pseudo
            // 
            this.lbl_Pseudo.AutoSize = true;
            this.lbl_Pseudo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Pseudo.Location = new System.Drawing.Point(82, 9);
            this.lbl_Pseudo.Name = "lbl_Pseudo";
            this.lbl_Pseudo.Size = new System.Drawing.Size(43, 13);
            this.lbl_Pseudo.TabIndex = 1;
            this.lbl_Pseudo.Text = "Pseudo";
            // 
            // lbl_Niveaux
            // 
            this.lbl_Niveaux.AutoSize = true;
            this.lbl_Niveaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Niveaux.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Niveaux.Location = new System.Drawing.Point(106, 28);
            this.lbl_Niveaux.Name = "lbl_Niveaux";
            this.lbl_Niveaux.Size = new System.Drawing.Size(52, 13);
            this.lbl_Niveaux.TabIndex = 2;
            this.lbl_Niveaux.Text = "Niveaux :";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Date.Location = new System.Drawing.Point(296, 8);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(82, 13);
            this.lbl_Date.TabIndex = 3;
            this.lbl_Date.Text = "Sauvegardé le :";
            // 
            // UC_LoadGameWithSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Lynaar_GUI.Properties.Resources.savedGame_Panel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Niveaux);
            this.Controls.Add(this.lbl_Pseudo);
            this.Controls.Add(this.picBox_ClasseIcon);
            this.DoubleBuffered = true;
            this.Name = "UC_LoadGameWithSave";
            this.Size = new System.Drawing.Size(387, 50);
            this.Load += new System.EventHandler(this.UC_LoadGameWithSave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ClasseIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_ClasseIcon;
        private System.Windows.Forms.Label lbl_Pseudo;
        private System.Windows.Forms.Label lbl_Niveaux;
        private System.Windows.Forms.Label lbl_Date;
    }
}
