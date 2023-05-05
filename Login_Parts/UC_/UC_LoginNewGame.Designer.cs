namespace Lynaar_GUI.Login_Parts.UC_
{
    partial class UC_LoginNewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_LoginNewGame));
            this.txtBoxPseudo = new System.Windows.Forms.TextBox();
            this.lblWho = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWhat = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblDescibClass = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblAtk = new System.Windows.Forms.Label();
            this.lblIntAndEndure = new System.Windows.Forms.Label();
            this.pbBackMenu = new System.Windows.Forms.PictureBox();
            this.pbIntAndEndure = new System.Windows.Forms.PictureBox();
            this.pbAtk = new System.Windows.Forms.PictureBox();
            this.pbHp = new System.Windows.Forms.PictureBox();
            this.picBox_NewGame = new System.Windows.Forms.PictureBox();
            this.rdbClasseRogue = new System.Windows.Forms.RadioButton();
            this.rdbClasseMage = new System.Windows.Forms.RadioButton();
            this.rdbClasseHunter = new System.Windows.Forms.RadioButton();
            this.rdbClasseWarrior = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIntAndEndure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_NewGame)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPseudo
            // 
            this.txtBoxPseudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(35)))), ((int)(((byte)(12)))));
            this.txtBoxPseudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPseudo.ForeColor = System.Drawing.Color.White;
            this.txtBoxPseudo.Location = new System.Drawing.Point(144, 117);
            this.txtBoxPseudo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPseudo.MaxLength = 255;
            this.txtBoxPseudo.Name = "txtBoxPseudo";
            this.txtBoxPseudo.Size = new System.Drawing.Size(114, 13);
            this.txtBoxPseudo.TabIndex = 0;
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.BackColor = System.Drawing.Color.Transparent;
            this.lblWho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWho.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWho.Location = new System.Drawing.Point(144, 37);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(77, 17);
            this.lblWho.TabIndex = 4;
            this.lblWho.Text = "Who are you ?";
            this.lblWho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWho.UseCompatibleTextRendering = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(155, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Your name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.UseCompatibleTextRendering = true;
            // 
            // lblWhat
            // 
            this.lblWhat.AutoSize = true;
            this.lblWhat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWhat.Location = new System.Drawing.Point(316, -4);
            this.lblWhat.Name = "lblWhat";
            this.lblWhat.Size = new System.Drawing.Size(74, 17);
            this.lblWhat.TabIndex = 6;
            this.lblWhat.Text = "Select a class";
            this.lblWhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWhat.UseCompatibleTextRendering = true;
            // 
            // lblError
            // 
            this.lblError.Location = new System.Drawing.Point(126, 230);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(166, 47);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "lblError";
            this.lblError.UseCompatibleTextRendering = true;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClass.Location = new System.Drawing.Point(495, 37);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(44, 17);
            this.lblClass.TabIndex = 13;
            this.lblClass.Text = "lblClass";
            this.lblClass.UseCompatibleTextRendering = true;
            this.lblClass.Visible = false;
            // 
            // lblDescibClass
            // 
            this.lblDescibClass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescibClass.Location = new System.Drawing.Point(495, 75);
            this.lblDescibClass.Name = "lblDescibClass";
            this.lblDescibClass.Size = new System.Drawing.Size(278, 160);
            this.lblDescibClass.TabIndex = 14;
            this.lblDescibClass.Text = "lblDescibClass";
            this.lblDescibClass.UseCompatibleTextRendering = true;
            this.lblDescibClass.Visible = false;
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHp.Location = new System.Drawing.Point(763, 255);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(30, 17);
            this.lblHp.TabIndex = 18;
            this.lblHp.Text = "lblHp";
            this.lblHp.UseCompatibleTextRendering = true;
            this.lblHp.Visible = false;
            // 
            // lblAtk
            // 
            this.lblAtk.AutoSize = true;
            this.lblAtk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAtk.Location = new System.Drawing.Point(863, 255);
            this.lblAtk.Name = "lblAtk";
            this.lblAtk.Size = new System.Drawing.Size(32, 17);
            this.lblAtk.TabIndex = 19;
            this.lblAtk.Text = "lblAtk";
            this.lblAtk.UseCompatibleTextRendering = true;
            this.lblAtk.Visible = false;
            // 
            // lblIntAndEndure
            // 
            this.lblIntAndEndure.AutoSize = true;
            this.lblIntAndEndure.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIntAndEndure.Location = new System.Drawing.Point(955, 255);
            this.lblIntAndEndure.Name = "lblIntAndEndure";
            this.lblIntAndEndure.Size = new System.Drawing.Size(85, 17);
            this.lblIntAndEndure.TabIndex = 20;
            this.lblIntAndEndure.Text = "lblIntAndEndure";
            this.lblIntAndEndure.UseCompatibleTextRendering = true;
            this.lblIntAndEndure.Visible = false;
            // 
            // pbBackMenu
            // 
            this.pbBackMenu.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Menu_Icon_x64;
            this.pbBackMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBackMenu.Location = new System.Drawing.Point(0, 3);
            this.pbBackMenu.Name = "pbBackMenu";
            this.pbBackMenu.Size = new System.Drawing.Size(51, 51);
            this.pbBackMenu.TabIndex = 21;
            this.pbBackMenu.TabStop = false;
            this.pbBackMenu.Click += new System.EventHandler(this.pbBackMenu_Click);
            this.pbBackMenu.MouseEnter += new System.EventHandler(this.hoverBackMenuButton);
            this.pbBackMenu.MouseLeave += new System.EventHandler(this.exitHoverBackMenuButton);
            // 
            // pbIntAndEndure
            // 
            this.pbIntAndEndure.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Endure32_Ico;
            this.pbIntAndEndure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIntAndEndure.Location = new System.Drawing.Point(661, 188);
            this.pbIntAndEndure.Name = "pbIntAndEndure";
            this.pbIntAndEndure.Size = new System.Drawing.Size(30, 30);
            this.pbIntAndEndure.TabIndex = 17;
            this.pbIntAndEndure.TabStop = false;
            this.pbIntAndEndure.Visible = false;
            // 
            // pbAtk
            // 
            this.pbAtk.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Atk32_Ico;
            this.pbAtk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAtk.Location = new System.Drawing.Point(579, 188);
            this.pbAtk.Name = "pbAtk";
            this.pbAtk.Size = new System.Drawing.Size(30, 30);
            this.pbAtk.TabIndex = 16;
            this.pbAtk.TabStop = false;
            this.pbAtk.Visible = false;
            // 
            // pbHp
            // 
            this.pbHp.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Hp32_Ico;
            this.pbHp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHp.Location = new System.Drawing.Point(509, 188);
            this.pbHp.Name = "pbHp";
            this.pbHp.Size = new System.Drawing.Size(30, 30);
            this.pbHp.TabIndex = 15;
            this.pbHp.TabStop = false;
            this.pbHp.Visible = false;
            // 
            // picBox_NewGame
            // 
            this.picBox_NewGame.BackgroundImage = global::Lynaar_GUI.Properties.Resources.StartGame_Parcho_Gris_A;
            this.picBox_NewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_NewGame.Location = new System.Drawing.Point(285, 188);
            this.picBox_NewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_NewGame.MaximumSize = new System.Drawing.Size(206, 47);
            this.picBox_NewGame.Name = "picBox_NewGame";
            this.picBox_NewGame.Size = new System.Drawing.Size(206, 47);
            this.picBox_NewGame.TabIndex = 10;
            this.picBox_NewGame.TabStop = false;
            this.picBox_NewGame.Click += new System.EventHandler(this.picBox_NewGame_Click);
            this.picBox_NewGame.MouseEnter += new System.EventHandler(this.hoverNewGameButton);
            this.picBox_NewGame.MouseLeave += new System.EventHandler(this.exitHoverNewGameButton);
            // 
            // rdbClasseRogue
            // 
            this.rdbClasseRogue.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbClasseRogue.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.rdbClasseRogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbClasseRogue.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbClasseRogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbClasseRogue.FlatAppearance.BorderSize = 0;
            this.rdbClasseRogue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseRogue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseRogue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseRogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbClasseRogue.ForeColor = System.Drawing.Color.Black;
            this.rdbClasseRogue.Image = ((System.Drawing.Image)(resources.GetObject("rdbClasseRogue.Image")));
            this.rdbClasseRogue.Location = new System.Drawing.Point(318, 103);
            this.rdbClasseRogue.Margin = new System.Windows.Forms.Padding(0);
            this.rdbClasseRogue.Name = "rdbClasseRogue";
            this.rdbClasseRogue.Size = new System.Drawing.Size(70, 70);
            this.rdbClasseRogue.TabIndex = 3;
            this.rdbClasseRogue.Tag = "classe";
            this.rdbClasseRogue.UseVisualStyleBackColor = true;
            this.rdbClasseRogue.CheckedChanged += new System.EventHandler(this.rdbClasseRogue_CheckedChanged);
            // 
            // rdbClasseMage
            // 
            this.rdbClasseMage.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbClasseMage.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.rdbClasseMage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbClasseMage.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbClasseMage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbClasseMage.FlatAppearance.BorderSize = 0;
            this.rdbClasseMage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseMage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseMage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseMage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbClasseMage.ForeColor = System.Drawing.Color.Black;
            this.rdbClasseMage.Image = global::Lynaar_GUI.Properties.Resources.Mage_IcoC;
            this.rdbClasseMage.Location = new System.Drawing.Point(395, 28);
            this.rdbClasseMage.Margin = new System.Windows.Forms.Padding(0);
            this.rdbClasseMage.Name = "rdbClasseMage";
            this.rdbClasseMage.Size = new System.Drawing.Size(70, 70);
            this.rdbClasseMage.TabIndex = 2;
            this.rdbClasseMage.Tag = "classe";
            this.rdbClasseMage.UseVisualStyleBackColor = true;
            this.rdbClasseMage.CheckedChanged += new System.EventHandler(this.rdbClasseMage_CheckedChanged);
            // 
            // rdbClasseHunter
            // 
            this.rdbClasseHunter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbClasseHunter.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.rdbClasseHunter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbClasseHunter.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbClasseHunter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbClasseHunter.FlatAppearance.BorderSize = 0;
            this.rdbClasseHunter.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseHunter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseHunter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseHunter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbClasseHunter.ForeColor = System.Drawing.Color.Black;
            this.rdbClasseHunter.Image = global::Lynaar_GUI.Properties.Resources.Hunter_IcoC;
            this.rdbClasseHunter.Location = new System.Drawing.Point(395, 103);
            this.rdbClasseHunter.Margin = new System.Windows.Forms.Padding(0);
            this.rdbClasseHunter.Name = "rdbClasseHunter";
            this.rdbClasseHunter.Size = new System.Drawing.Size(70, 70);
            this.rdbClasseHunter.TabIndex = 4;
            this.rdbClasseHunter.Tag = "classe";
            this.rdbClasseHunter.UseVisualStyleBackColor = true;
            this.rdbClasseHunter.CheckedChanged += new System.EventHandler(this.rdbClasseHunter_CheckedChanged);
            // 
            // rdbClasseWarrior
            // 
            this.rdbClasseWarrior.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbClasseWarrior.BackColor = System.Drawing.Color.Transparent;
            this.rdbClasseWarrior.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.rdbClasseWarrior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbClasseWarrior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbClasseWarrior.FlatAppearance.BorderSize = 0;
            this.rdbClasseWarrior.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseWarrior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseWarrior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rdbClasseWarrior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbClasseWarrior.ForeColor = System.Drawing.Color.Black;
            this.rdbClasseWarrior.Image = global::Lynaar_GUI.Properties.Resources.Warrior_IcoC;
            this.rdbClasseWarrior.Location = new System.Drawing.Point(318, 28);
            this.rdbClasseWarrior.Margin = new System.Windows.Forms.Padding(0);
            this.rdbClasseWarrior.Name = "rdbClasseWarrior";
            this.rdbClasseWarrior.Size = new System.Drawing.Size(70, 70);
            this.rdbClasseWarrior.TabIndex = 1;
            this.rdbClasseWarrior.Tag = "classe";
            this.rdbClasseWarrior.UseVisualStyleBackColor = false;
            this.rdbClasseWarrior.CheckedChanged += new System.EventHandler(this.rdbClasseWarrior_CheckedChanged);
            // 
            // UC_LoginNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pbBackMenu);
            this.Controls.Add(this.lblIntAndEndure);
            this.Controls.Add(this.lblAtk);
            this.Controls.Add(this.lblHp);
            this.Controls.Add(this.pbIntAndEndure);
            this.Controls.Add(this.pbAtk);
            this.Controls.Add(this.pbHp);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.picBox_NewGame);
            this.Controls.Add(this.rdbClasseRogue);
            this.Controls.Add(this.rdbClasseMage);
            this.Controls.Add(this.lblWhat);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWho);
            this.Controls.Add(this.rdbClasseHunter);
            this.Controls.Add(this.rdbClasseWarrior);
            this.Controls.Add(this.txtBoxPseudo);
            this.Controls.Add(this.lblDescibClass);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_LoginNewGame";
            this.Size = new System.Drawing.Size(776, 242);
            this.Load += new System.EventHandler(this.UC_LoginNewGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIntAndEndure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_NewGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPseudo;
        private System.Windows.Forms.RadioButton rdbClasseWarrior;
        private System.Windows.Forms.RadioButton rdbClasseHunter;

        private System.Windows.Forms.Label lblWho;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWhat;
        private System.Windows.Forms.RadioButton rdbClasseMage;
        private System.Windows.Forms.RadioButton rdbClasseRogue;
        private System.Windows.Forms.PictureBox picBox_NewGame;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblDescibClass;
        private System.Windows.Forms.PictureBox pbHp;
        private System.Windows.Forms.PictureBox pbAtk;
        private System.Windows.Forms.PictureBox pbIntAndEndure;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblAtk;
        private System.Windows.Forms.Label lblIntAndEndure;
        private System.Windows.Forms.PictureBox pbBackMenu;
    }
}
