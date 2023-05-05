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
            this.pnl_Save1 = new System.Windows.Forms.Panel();
            this.pnl_Save2 = new System.Windows.Forms.Panel();
            this.pnl_Save3 = new System.Windows.Forms.Panel();
            this.picBox_Delete2 = new System.Windows.Forms.PictureBox();
            this.picBox_Delete3 = new System.Windows.Forms.PictureBox();
            this.picBox_Delete1 = new System.Windows.Forms.PictureBox();
            this.picBoxBackBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Delete2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Delete3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Delete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Save1
            // 
            this.pnl_Save1.Location = new System.Drawing.Point(193, 13);
            this.pnl_Save1.Name = "pnl_Save1";
            this.pnl_Save1.Size = new System.Drawing.Size(387, 50);
            this.pnl_Save1.TabIndex = 1;
            // 
            // pnl_Save2
            // 
            this.pnl_Save2.Location = new System.Drawing.Point(193, 69);
            this.pnl_Save2.Name = "pnl_Save2";
            this.pnl_Save2.Size = new System.Drawing.Size(387, 50);
            this.pnl_Save2.TabIndex = 2;
            // 
            // pnl_Save3
            // 
            this.pnl_Save3.Location = new System.Drawing.Point(193, 125);
            this.pnl_Save3.Name = "pnl_Save3";
            this.pnl_Save3.Size = new System.Drawing.Size(387, 50);
            this.pnl_Save3.TabIndex = 2;
            // 
            // picBox_Delete2
            // 
            this.picBox_Delete2.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Delete2.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.picBox_Delete2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_Delete2.Image = global::Lynaar_GUI.Properties.Resources.redCross_x32;
            this.picBox_Delete2.Location = new System.Drawing.Point(589, 69);
            this.picBox_Delete2.Name = "picBox_Delete2";
            this.picBox_Delete2.Size = new System.Drawing.Size(50, 50);
            this.picBox_Delete2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_Delete2.TabIndex = 5;
            this.picBox_Delete2.TabStop = false;
            this.picBox_Delete2.Click += new System.EventHandler(this.deleteSave);
            this.picBox_Delete2.MouseEnter += new System.EventHandler(this.hoverDeleteBtn);
            this.picBox_Delete2.MouseLeave += new System.EventHandler(this.returnToNormalDel);
            // 
            // picBox_Delete3
            // 
            this.picBox_Delete3.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Delete3.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.picBox_Delete3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_Delete3.Image = global::Lynaar_GUI.Properties.Resources.redCross_x32;
            this.picBox_Delete3.Location = new System.Drawing.Point(589, 125);
            this.picBox_Delete3.Name = "picBox_Delete3";
            this.picBox_Delete3.Size = new System.Drawing.Size(50, 50);
            this.picBox_Delete3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_Delete3.TabIndex = 4;
            this.picBox_Delete3.TabStop = false;
            this.picBox_Delete3.Click += new System.EventHandler(this.deleteSave);
            this.picBox_Delete3.MouseEnter += new System.EventHandler(this.hoverDeleteBtn);
            this.picBox_Delete3.MouseLeave += new System.EventHandler(this.returnToNormalDel);
            // 
            // picBox_Delete1
            // 
            this.picBox_Delete1.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Delete1.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.picBox_Delete1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_Delete1.Image = global::Lynaar_GUI.Properties.Resources.redCross_x32;
            this.picBox_Delete1.Location = new System.Drawing.Point(589, 13);
            this.picBox_Delete1.Name = "picBox_Delete1";
            this.picBox_Delete1.Size = new System.Drawing.Size(50, 50);
            this.picBox_Delete1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_Delete1.TabIndex = 3;
            this.picBox_Delete1.TabStop = false;
            this.picBox_Delete1.Click += new System.EventHandler(this.deleteSave);
            this.picBox_Delete1.MouseEnter += new System.EventHandler(this.hoverDeleteBtn);
            this.picBox_Delete1.MouseLeave += new System.EventHandler(this.returnToNormalDel);
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
            this.picBoxBackBtn.MouseEnter += new System.EventHandler(this.hoverBackBtn);
            this.picBoxBackBtn.MouseLeave += new System.EventHandler(this.exitHoverBackBtn);
            // 
            // UC_LoginLoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.picBox_Delete2);
            this.Controls.Add(this.picBox_Delete3);
            this.Controls.Add(this.picBox_Delete1);
            this.Controls.Add(this.pnl_Save2);
            this.Controls.Add(this.pnl_Save3);
            this.Controls.Add(this.pnl_Save1);
            this.Controls.Add(this.picBoxBackBtn);
            this.Name = "UC_LoginLoadGame";
            this.Size = new System.Drawing.Size(776, 242);
            this.Load += new System.EventHandler(this.UC_LoginLoadGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Delete2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Delete3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Delete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBackBtn;
        private System.Windows.Forms.Panel pnl_Save1;
        private System.Windows.Forms.Panel pnl_Save2;
        private System.Windows.Forms.Panel pnl_Save3;
        private System.Windows.Forms.PictureBox picBox_Delete1;
        private System.Windows.Forms.PictureBox picBox_Delete3;
        private System.Windows.Forms.PictureBox picBox_Delete2;
    }
}
