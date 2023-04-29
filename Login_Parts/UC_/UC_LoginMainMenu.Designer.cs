namespace Lynaar_GUI.Login_Parts.UC_
{
    partial class UC_LoginMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_LoginMainMenu));
            this.picBox_ExitGame = new System.Windows.Forms.PictureBox();
            this.picBox_LoadGame = new System.Windows.Forms.PictureBox();
            this.picBox_NewGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ExitGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_LoadGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_NewGame)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_ExitGame
            // 
            this.picBox_ExitGame.BackgroundImage = global::Lynaar_GUI.Properties.Resources.ExitGame_Parcho_Gris_A;
            this.picBox_ExitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_ExitGame.Location = new System.Drawing.Point(253, 163);
            this.picBox_ExitGame.MaximumSize = new System.Drawing.Size(275, 58);
            this.picBox_ExitGame.Name = "picBox_ExitGame";
            this.picBox_ExitGame.Size = new System.Drawing.Size(275, 58);
            this.picBox_ExitGame.TabIndex = 4;
            this.picBox_ExitGame.TabStop = false;
            this.picBox_ExitGame.Click += new System.EventHandler(this.picBox_ExitGame_Click);
            this.picBox_ExitGame.MouseEnter += new System.EventHandler(this.hoverExitBtn);
            this.picBox_ExitGame.MouseLeave += new System.EventHandler(this.exitHoverExitBtn);
            // 
            // picBox_LoadGame
            // 
            this.picBox_LoadGame.BackgroundImage = global::Lynaar_GUI.Properties.Resources.LoadGame_Parcho_Gris_A;
            this.picBox_LoadGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_LoadGame.Location = new System.Drawing.Point(253, 97);
            this.picBox_LoadGame.MaximumSize = new System.Drawing.Size(275, 58);
            this.picBox_LoadGame.Name = "picBox_LoadGame";
            this.picBox_LoadGame.Size = new System.Drawing.Size(275, 58);
            this.picBox_LoadGame.TabIndex = 3;
            this.picBox_LoadGame.TabStop = false;
            this.picBox_LoadGame.Click += new System.EventHandler(this.picBox_LoadGame_Click);
            this.picBox_LoadGame.MouseEnter += new System.EventHandler(this.hoverLoadBtn);
            this.picBox_LoadGame.MouseLeave += new System.EventHandler(this.exitHoverLoadBtn);
            // 
            // picBox_NewGame
            // 
            this.picBox_NewGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_NewGame.BackgroundImage")));
            this.picBox_NewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_NewGame.Location = new System.Drawing.Point(253, 27);
            this.picBox_NewGame.MaximumSize = new System.Drawing.Size(275, 58);
            this.picBox_NewGame.Name = "picBox_NewGame";
            this.picBox_NewGame.Size = new System.Drawing.Size(275, 58);
            this.picBox_NewGame.TabIndex = 2;
            this.picBox_NewGame.TabStop = false;
            this.picBox_NewGame.Click += new System.EventHandler(this.picBox_NewGame_Click);
            this.picBox_NewGame.MouseEnter += new System.EventHandler(this.hoverNewBtn);
            this.picBox_NewGame.MouseLeave += new System.EventHandler(this.exitHoverNewBtn);
            // 
            // UC_LoginMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picBox_ExitGame);
            this.Controls.Add(this.picBox_LoadGame);
            this.Controls.Add(this.picBox_NewGame);
            this.Name = "UC_LoginMainMenu";
            this.Size = new System.Drawing.Size(776, 242);
            this.Load += new System.EventHandler(this.UC_LoginMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ExitGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_LoadGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_NewGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picBox_NewGame;
        private System.Windows.Forms.PictureBox picBox_LoadGame;
        private System.Windows.Forms.PictureBox picBox_ExitGame;
    }
}
