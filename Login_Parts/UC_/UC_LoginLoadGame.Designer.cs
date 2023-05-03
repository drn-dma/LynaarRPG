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
            this.pnl_Save2 = new System.Windows.Forms.Panel();
            this.pnl_Save3 = new System.Windows.Forms.Panel();
            this.pnl_Save1 = new System.Windows.Forms.Panel();
            this.picBoxBackBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Save2
            // 
            this.pnl_Save2.BackColor = System.Drawing.Color.DimGray;
            this.pnl_Save2.Location = new System.Drawing.Point(195, 68);
            this.pnl_Save2.Name = "pnl_Save2";
            this.pnl_Save2.Size = new System.Drawing.Size(387, 50);
            this.pnl_Save2.TabIndex = 2;
            // 
            // pnl_Save3
            // 
            this.pnl_Save3.BackColor = System.Drawing.Color.DimGray;
            this.pnl_Save3.Location = new System.Drawing.Point(195, 125);
            this.pnl_Save3.Name = "pnl_Save3";
            this.pnl_Save3.Size = new System.Drawing.Size(387, 50);
            this.pnl_Save3.TabIndex = 2;
            // 
            // pnl_Save1
            // 
            this.pnl_Save1.BackColor = System.Drawing.Color.DimGray;
            this.pnl_Save1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Save1.Location = new System.Drawing.Point(195, 11);
            this.pnl_Save1.MaximumSize = new System.Drawing.Size(387, 50);
            this.pnl_Save1.MinimumSize = new System.Drawing.Size(387, 50);
            this.pnl_Save1.Name = "pnl_Save1";
            this.pnl_Save1.Size = new System.Drawing.Size(387, 50);
            this.pnl_Save1.TabIndex = 1;
            // 
            // picBoxBackBtn
            // 
            this.picBoxBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.picBoxBackBtn.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Back_Parcho_Gris_A;
            this.picBoxBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxBackBtn.Location = new System.Drawing.Point(589, 184);
            this.picBoxBackBtn.Name = "picBoxBackBtn";
            this.picBoxBackBtn.Size = new System.Drawing.Size(184, 55);
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
            this.Controls.Add(this.pnl_Save3);
            this.Controls.Add(this.pnl_Save2);
            this.Controls.Add(this.pnl_Save1);
            this.Controls.Add(this.picBoxBackBtn);
            this.Name = "UC_LoginLoadGame";
            this.Size = new System.Drawing.Size(776, 242);
            this.Load += new System.EventHandler(this.UC_LoginLoadGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBackBtn;
        private System.Windows.Forms.Panel pnl_Save1;
        private System.Windows.Forms.Panel pnl_Save2;
        private System.Windows.Forms.Panel pnl_Save3;
    }
}
