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
            this.lblClassName = new System.Windows.Forms.Label();
            this.rdbClasseRogue = new System.Windows.Forms.RadioButton();
            this.rdbClasseMage = new System.Windows.Forms.RadioButton();
            this.rdbClasseHunter = new System.Windows.Forms.RadioButton();
            this.rdbClasseWarrior = new System.Windows.Forms.RadioButton();
            this.picBox_NewGame = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_NewGame)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPseudo
            // 
            this.txtBoxPseudo.BackColor = System.Drawing.Color.FloralWhite;
            this.txtBoxPseudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPseudo.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPseudo.Location = new System.Drawing.Point(139, 121);
            this.txtBoxPseudo.MaxLength = 255;
            this.txtBoxPseudo.Name = "txtBoxPseudo";
            this.txtBoxPseudo.Size = new System.Drawing.Size(114, 13);
            this.txtBoxPseudo.TabIndex = 0;
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWho.Location = new System.Drawing.Point(124, 24);
            this.lblWho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(77, 17);
            this.lblWho.TabIndex = 4;
            this.lblWho.Text = "Who are you ?";
            this.lblWho.UseCompatibleTextRendering = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(149, 88);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Your name";
            this.lblName.UseCompatibleTextRendering = true;
            // 
            // lblWhat
            // 
            this.lblWhat.AutoSize = true;
            this.lblWhat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWhat.Location = new System.Drawing.Point(512, 24);
            this.lblWhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhat.Name = "lblWhat";
            this.lblWhat.Size = new System.Drawing.Size(81, 17);
            this.lblWhat.TabIndex = 6;
            this.lblWhat.Text = "What are you ?";
            this.lblWhat.UseCompatibleTextRendering = true;
            // 
            // lblClassName
            // 
            this.lblClassName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClassName.Location = new System.Drawing.Point(538, 148);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(75, 19);
            this.lblClassName.TabIndex = 9;
            this.lblClassName.UseCompatibleTextRendering = true;
            // 
            // rdbClasseRogue
            // 
            this.rdbClasseRogue.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbClasseRogue.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.rdbClasseRogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbClasseRogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbClasseRogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbClasseRogue.ForeColor = System.Drawing.Color.Black;
            this.rdbClasseRogue.Image = ((System.Drawing.Image)(resources.GetObject("rdbClasseRogue.Image")));
            this.rdbClasseRogue.Location = new System.Drawing.Point(575, 65);
            this.rdbClasseRogue.Name = "rdbClasseRogue";
            this.rdbClasseRogue.Size = new System.Drawing.Size(61, 58);
            this.rdbClasseRogue.TabIndex = 8;
            this.rdbClasseRogue.TabStop = true;
            this.rdbClasseRogue.Tag = "classe";
            this.rdbClasseRogue.UseVisualStyleBackColor = true;
            this.rdbClasseRogue.CheckedChanged += new System.EventHandler(this.rdbClasseRogue_CheckedChanged);
            // 
            // rdbClasseMage
            // 
            this.rdbClasseMage.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbClasseMage.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.rdbClasseMage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbClasseMage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbClasseMage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbClasseMage.ForeColor = System.Drawing.Color.Black;
            this.rdbClasseMage.Image = global::Lynaar_GUI.Properties.Resources.Mage_IcoC;
            this.rdbClasseMage.Location = new System.Drawing.Point(512, 65);
            this.rdbClasseMage.Name = "rdbClasseMage";
            this.rdbClasseMage.Size = new System.Drawing.Size(57, 58);
            this.rdbClasseMage.TabIndex = 7;
            this.rdbClasseMage.TabStop = true;
            this.rdbClasseMage.Tag = "classe";
            this.rdbClasseMage.UseVisualStyleBackColor = true;
            this.rdbClasseMage.CheckedChanged += new System.EventHandler(this.rdbClasseMage_CheckedChanged);
            // 
            // rdbClasseHunter
            // 
            this.rdbClasseHunter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbClasseHunter.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.rdbClasseHunter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbClasseHunter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbClasseHunter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbClasseHunter.ForeColor = System.Drawing.Color.Black;
            this.rdbClasseHunter.Image = global::Lynaar_GUI.Properties.Resources.Hunter_IcoC;
            this.rdbClasseHunter.Location = new System.Drawing.Point(642, 65);
            this.rdbClasseHunter.Name = "rdbClasseHunter";
            this.rdbClasseHunter.Size = new System.Drawing.Size(60, 58);
            this.rdbClasseHunter.TabIndex = 2;
            this.rdbClasseHunter.TabStop = true;
            this.rdbClasseHunter.Tag = "classe";
            this.rdbClasseHunter.UseVisualStyleBackColor = true;
            this.rdbClasseHunter.CheckedChanged += new System.EventHandler(this.rdbClasseHunter_CheckedChanged);
            // 
            // rdbClasseWarrior
            // 
            this.rdbClasseWarrior.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbClasseWarrior.BackColor = System.Drawing.Color.Black;
            this.rdbClasseWarrior.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.rdbClasseWarrior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbClasseWarrior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbClasseWarrior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbClasseWarrior.ForeColor = System.Drawing.Color.Black;
            this.rdbClasseWarrior.Image = global::Lynaar_GUI.Properties.Resources.Warrior_IcoC;
            this.rdbClasseWarrior.Location = new System.Drawing.Point(446, 65);
            this.rdbClasseWarrior.Name = "rdbClasseWarrior";
            this.rdbClasseWarrior.Size = new System.Drawing.Size(61, 58);
            this.rdbClasseWarrior.TabIndex = 1;
            this.rdbClasseWarrior.TabStop = true;
            this.rdbClasseWarrior.Tag = "classe";
            this.rdbClasseWarrior.UseVisualStyleBackColor = false;
            this.rdbClasseWarrior.CheckedChanged += new System.EventHandler(this.rdbClasseWarrior_CheckedChanged);
            // 
            // picBox_NewGame
            // 
            this.picBox_NewGame.BackgroundImage = global::Lynaar_GUI.Properties.Resources.NewGame_Parcho_Gris_A;
            this.picBox_NewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_NewGame.Location = new System.Drawing.Point(284, 173);
            this.picBox_NewGame.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_NewGame.MaximumSize = new System.Drawing.Size(206, 47);
            this.picBox_NewGame.Name = "picBox_NewGame";
            this.picBox_NewGame.Size = new System.Drawing.Size(206, 47);
            this.picBox_NewGame.TabIndex = 10;
            this.picBox_NewGame.TabStop = false;
            this.picBox_NewGame.Click += new System.EventHandler(this.picBox_NewGame_Click);
            this.picBox_NewGame.MouseEnter += new System.EventHandler(this.hoverNewGameButton);
            this.picBox_NewGame.MouseLeave += new System.EventHandler(this.exitHoverNewGameButton);
            // 
            // lblError
            // 
            this.lblError.Location = new System.Drawing.Point(536, 173);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(166, 47);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "lblError";
            this.lblError.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_LoginNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.picBox_NewGame);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.rdbClasseRogue);
            this.Controls.Add(this.rdbClasseMage);
            this.Controls.Add(this.lblWhat);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWho);
            this.Controls.Add(this.rdbClasseHunter);
            this.Controls.Add(this.rdbClasseWarrior);
            this.Controls.Add(this.txtBoxPseudo);
            this.Name = "UC_LoginNewGame";
            this.Size = new System.Drawing.Size(776, 242);
            this.Load += new System.EventHandler(this.UC_LoginNewGame_Load);
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
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.PictureBox picBox_NewGame;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button button1;
    }
}
