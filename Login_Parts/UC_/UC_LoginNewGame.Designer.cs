﻿namespace Lynaar_GUI.Login_Parts.UC_
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
            this.lblError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picBox_NewGame = new System.Windows.Forms.PictureBox();
            this.rdbClasseRogue = new System.Windows.Forms.RadioButton();
            this.rdbClasseMage = new System.Windows.Forms.RadioButton();
            this.rdbClasseHunter = new System.Windows.Forms.RadioButton();
            this.rdbClasseWarrior = new System.Windows.Forms.RadioButton();
            this.pbWho = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_NewGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWho)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPseudo
            // 
            this.txtBoxPseudo.BackColor = System.Drawing.Color.Thistle;
            this.txtBoxPseudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPseudo.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPseudo.Location = new System.Drawing.Point(127, 183);
            this.txtBoxPseudo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPseudo.MaxLength = 255;
            this.txtBoxPseudo.Name = "txtBoxPseudo";
            this.txtBoxPseudo.Size = new System.Drawing.Size(152, 15);
            this.txtBoxPseudo.TabIndex = 0;
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.BackColor = System.Drawing.Color.Transparent;
            this.lblWho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWho.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWho.Location = new System.Drawing.Point(154, 69);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(91, 20);
            this.lblWho.TabIndex = 4;
            this.lblWho.Text = "Who are you ?";
            this.lblWho.UseCompatibleTextRendering = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(164, 159);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Your name";
            this.lblName.UseCompatibleTextRendering = true;
            // 
            // lblWhat
            // 
            this.lblWhat.AutoSize = true;
            this.lblWhat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWhat.Location = new System.Drawing.Point(501, 21);
            this.lblWhat.Name = "lblWhat";
            this.lblWhat.Size = new System.Drawing.Size(95, 20);
            this.lblWhat.TabIndex = 6;
            this.lblWhat.Text = "What are you ?";
            this.lblWhat.UseCompatibleTextRendering = true;
            // 
            // lblClassName
            // 
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClassName.Location = new System.Drawing.Point(501, 231);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(100, 23);
            this.lblClassName.TabIndex = 9;
            this.lblClassName.Text = "className";
            this.lblClassName.UseCompatibleTextRendering = true;
            // 
            // lblError
            // 
            this.lblError.Location = new System.Drawing.Point(719, 69);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(221, 58);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "lblError";
            this.lblError.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(905, 177);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox_NewGame
            // 
            this.picBox_NewGame.BackgroundImage = global::Lynaar_GUI.Properties.Resources.StartGame_Parcho_Gris_A;
            this.picBox_NewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_NewGame.Location = new System.Drawing.Point(730, 223);
            this.picBox_NewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_NewGame.MaximumSize = new System.Drawing.Size(275, 58);
            this.picBox_NewGame.Name = "picBox_NewGame";
            this.picBox_NewGame.Size = new System.Drawing.Size(275, 58);
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
            this.rdbClasseRogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbClasseRogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbClasseRogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbClasseRogue.ForeColor = System.Drawing.Color.Black;
            this.rdbClasseRogue.Image = ((System.Drawing.Image)(resources.GetObject("rdbClasseRogue.Image")));
            this.rdbClasseRogue.Location = new System.Drawing.Point(464, 134);
            this.rdbClasseRogue.Margin = new System.Windows.Forms.Padding(4);
            this.rdbClasseRogue.Name = "rdbClasseRogue";
            this.rdbClasseRogue.Size = new System.Drawing.Size(81, 71);
            this.rdbClasseRogue.TabIndex = 3;
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
            this.rdbClasseMage.Location = new System.Drawing.Point(553, 56);
            this.rdbClasseMage.Margin = new System.Windows.Forms.Padding(4);
            this.rdbClasseMage.Name = "rdbClasseMage";
            this.rdbClasseMage.Size = new System.Drawing.Size(76, 71);
            this.rdbClasseMage.TabIndex = 2;
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
            this.rdbClasseHunter.Location = new System.Drawing.Point(553, 135);
            this.rdbClasseHunter.Margin = new System.Windows.Forms.Padding(4);
            this.rdbClasseHunter.Name = "rdbClasseHunter";
            this.rdbClasseHunter.Size = new System.Drawing.Size(80, 71);
            this.rdbClasseHunter.TabIndex = 4;
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
            this.rdbClasseWarrior.Location = new System.Drawing.Point(464, 56);
            this.rdbClasseWarrior.Margin = new System.Windows.Forms.Padding(4);
            this.rdbClasseWarrior.Name = "rdbClasseWarrior";
            this.rdbClasseWarrior.Size = new System.Drawing.Size(81, 71);
            this.rdbClasseWarrior.TabIndex = 1;
            this.rdbClasseWarrior.TabStop = true;
            this.rdbClasseWarrior.Tag = "classe";
            this.rdbClasseWarrior.UseVisualStyleBackColor = false;
            this.rdbClasseWarrior.CheckedChanged += new System.EventHandler(this.rdbClasseWarrior_CheckedChanged);
            // 
            // pbWho
            // 
            this.pbWho.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Parchos_Gris_Grand;
            this.pbWho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbWho.Location = new System.Drawing.Point(30, 21);
            this.pbWho.Name = "pbWho";
            this.pbWho.Size = new System.Drawing.Size(343, 233);
            this.pbWho.TabIndex = 13;
            this.pbWho.TabStop = false;
            // 
            // UC_LoginNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Controls.Add(this.pbWho);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_LoginNewGame";
            this.Size = new System.Drawing.Size(1035, 298);
            this.Load += new System.EventHandler(this.UC_LoginNewGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_NewGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWho)).EndInit();
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
        private System.Windows.Forms.PictureBox pbWho;
    }
}
