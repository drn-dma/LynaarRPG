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
            this.lbl_Niv = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Level = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBoxIntEnd = new System.Windows.Forms.PictureBox();
            this.lbl_Hp = new System.Windows.Forms.Label();
            this.lbl_Atk = new System.Windows.Forms.Label();
            this.lbl_IntEnd = new System.Windows.Forms.Label();
            this.lbl_DateSave = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ClasseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIntEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_ClasseIcon
            // 
            this.picBox_ClasseIcon.BackgroundImage = global::Lynaar_GUI.Properties.Resources.savedGame_BackFrame;
            this.picBox_ClasseIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_ClasseIcon.Location = new System.Drawing.Point(26, 8);
            this.picBox_ClasseIcon.Name = "picBox_ClasseIcon";
            this.picBox_ClasseIcon.Size = new System.Drawing.Size(32, 32);
            this.picBox_ClasseIcon.TabIndex = 0;
            this.picBox_ClasseIcon.TabStop = false;
            // 
            // lbl_Pseudo
            // 
            this.lbl_Pseudo.AutoSize = true;
            this.lbl_Pseudo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Pseudo.Location = new System.Drawing.Point(82, 9);
            this.lbl_Pseudo.Name = "lbl_Pseudo";
            this.lbl_Pseudo.Size = new System.Drawing.Size(43, 17);
            this.lbl_Pseudo.TabIndex = 1;
            this.lbl_Pseudo.Text = "Pseudo";
            this.lbl_Pseudo.UseCompatibleTextRendering = true;
            // 
            // lbl_Niv
            // 
            this.lbl_Niv.AutoSize = true;
            this.lbl_Niv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Niv.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Niv.Location = new System.Drawing.Point(82, 26);
            this.lbl_Niv.Name = "lbl_Niv";
            this.lbl_Niv.Size = new System.Drawing.Size(39, 17);
            this.lbl_Niv.TabIndex = 2;
            this.lbl_Niv.Text = "Level :";
            this.lbl_Niv.UseCompatibleTextRendering = true;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Date.Location = new System.Drawing.Point(323, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(44, 17);
            this.lbl_Date.TabIndex = 3;
            this.lbl_Date.Text = "Saved :";
            this.lbl_Date.UseCompatibleTextRendering = true;
            // 
            // lbl_Level
            // 
            this.lbl_Level.AutoSize = true;
            this.lbl_Level.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Level.Location = new System.Drawing.Point(125, 26);
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.Size = new System.Drawing.Size(55, 17);
            this.lbl_Level.TabIndex = 4;
            this.lbl_Level.Text = "lvlNumber";
            this.lbl_Level.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lynaar_GUI.Properties.Resources.Hp16_Ico;
            this.pictureBox1.Location = new System.Drawing.Point(173, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lynaar_GUI.Properties.Resources.Atk16_Ico;
            this.pictureBox2.Location = new System.Drawing.Point(239, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // picBoxIntEnd
            // 
            this.picBoxIntEnd.Location = new System.Drawing.Point(173, 27);
            this.picBoxIntEnd.Name = "picBoxIntEnd";
            this.picBoxIntEnd.Size = new System.Drawing.Size(16, 16);
            this.picBoxIntEnd.TabIndex = 7;
            this.picBoxIntEnd.TabStop = false;
            // 
            // lbl_Hp
            // 
            this.lbl_Hp.AutoSize = true;
            this.lbl_Hp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Hp.Location = new System.Drawing.Point(195, 9);
            this.lbl_Hp.Name = "lbl_Hp";
            this.lbl_Hp.Size = new System.Drawing.Size(29, 17);
            this.lbl_Hp.TabIndex = 8;
            this.lbl_Hp.Text = "9999";
            this.lbl_Hp.UseCompatibleTextRendering = true;
            // 
            // lbl_Atk
            // 
            this.lbl_Atk.AutoSize = true;
            this.lbl_Atk.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Atk.Location = new System.Drawing.Point(261, 9);
            this.lbl_Atk.Name = "lbl_Atk";
            this.lbl_Atk.Size = new System.Drawing.Size(29, 17);
            this.lbl_Atk.TabIndex = 9;
            this.lbl_Atk.Text = "9999";
            this.lbl_Atk.UseCompatibleTextRendering = true;
            // 
            // lbl_IntEnd
            // 
            this.lbl_IntEnd.AutoSize = true;
            this.lbl_IntEnd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_IntEnd.Location = new System.Drawing.Point(195, 26);
            this.lbl_IntEnd.Name = "lbl_IntEnd";
            this.lbl_IntEnd.Size = new System.Drawing.Size(29, 17);
            this.lbl_IntEnd.TabIndex = 10;
            this.lbl_IntEnd.Text = "9999";
            this.lbl_IntEnd.UseCompatibleTextRendering = true;
            // 
            // lbl_DateSave
            // 
            this.lbl_DateSave.AutoSize = true;
            this.lbl_DateSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_DateSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_DateSave.Location = new System.Drawing.Point(313, 27);
            this.lbl_DateSave.Name = "lbl_DateSave";
            this.lbl_DateSave.Size = new System.Drawing.Size(26, 17);
            this.lbl_DateSave.TabIndex = 11;
            this.lbl_DateSave.Text = "date";
            this.lbl_DateSave.UseCompatibleTextRendering = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Lynaar_GUI.Properties.Resources.separateBarre;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(298, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 35);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // UC_LoadGameWithSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Lynaar_GUI.Properties.Resources.savedGame_Panel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_DateSave);
            this.Controls.Add(this.lbl_IntEnd);
            this.Controls.Add(this.lbl_Atk);
            this.Controls.Add(this.lbl_Hp);
            this.Controls.Add(this.picBoxIntEnd);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Level);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Niv);
            this.Controls.Add(this.lbl_Pseudo);
            this.Controls.Add(this.picBox_ClasseIcon);
            this.DoubleBuffered = true;
            this.Name = "UC_LoadGameWithSave";
            this.Size = new System.Drawing.Size(387, 50);
            this.Load += new System.EventHandler(this.UC_LoadGameWithSave_Load);
            this.Click += new System.EventHandler(this.UC_LoadGameWithSave_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ClasseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIntEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Pseudo;
        private System.Windows.Forms.Label lbl_Niv;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.PictureBox picBox_ClasseIcon;
        private System.Windows.Forms.Label lbl_Level;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBoxIntEnd;
        private System.Windows.Forms.Label lbl_Hp;
        private System.Windows.Forms.Label lbl_Atk;
        private System.Windows.Forms.Label lbl_IntEnd;
        private System.Windows.Forms.Label lbl_DateSave;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
