namespace Lynaar_GUI.Login_Parts.UC_
{
    partial class UC_LoginLoadGame
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
            this.picBoxBackBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxBackBtn
            // 
            this.picBoxBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.picBoxBackBtn.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Back_Parcho_Gris_A;
            this.picBoxBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxBackBtn.Location = new System.Drawing.Point(505, 138);
            this.picBoxBackBtn.Name = "picBoxBackBtn";
            this.picBoxBackBtn.Size = new System.Drawing.Size(246, 87);
            this.picBoxBackBtn.TabIndex = 0;
            this.picBoxBackBtn.TabStop = false;
            this.picBoxBackBtn.Click += new System.EventHandler(this.picBoxBackBtn_Click);
            this.picBoxBackBtn.MouseEnter += new System.EventHandler(this.hoverNewBtn);
            this.picBoxBackBtn.MouseLeave += new System.EventHandler(this.exitHoverNewBtn);
            // 
            // UC_LoginLoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.picBoxBackBtn);
            this.Name = "UC_LoginLoadGame";
            this.Size = new System.Drawing.Size(776, 242);
            this.Load += new System.EventHandler(this.UC_LoginLoadGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBackBtn;
    }
}
