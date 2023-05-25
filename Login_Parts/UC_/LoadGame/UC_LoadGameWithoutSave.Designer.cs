namespace Lynaar_GUI.Login_Parts.UC_.LoadGame
{
    partial class UC_LoadGameWithoutSave
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
            this.lbl_Empty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Empty
            // 
            this.lbl_Empty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Empty.AutoSize = true;
            this.lbl_Empty.ForeColor = System.Drawing.Color.White;
            this.lbl_Empty.Location = new System.Drawing.Point(163, 12);
            this.lbl_Empty.Name = "lbl_Empty";
            this.lbl_Empty.Size = new System.Drawing.Size(36, 17);
            this.lbl_Empty.TabIndex = 0;
            this.lbl_Empty.Text = "Empty";
            this.lbl_Empty.UseCompatibleTextRendering = true;
            // 
            // UC_LoadGameWithoutSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Lynaar_GUI.Properties.Resources.no_SavedGame_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_Empty);
            this.DoubleBuffered = true;
            this.Name = "UC_LoadGameWithoutSave";
            this.Size = new System.Drawing.Size(387, 50);
            this.Load += new System.EventHandler(this.UC_LoadGameWithoutSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Empty;
    }
}
