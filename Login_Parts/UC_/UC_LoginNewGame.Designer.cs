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
            this.rbClasseRogue = new System.Windows.Forms.RadioButton();
            this.rdClasseMage = new System.Windows.Forms.RadioButton();
            this.btnStartNewGame = new System.Windows.Forms.Button();

            this.rbClasseHunter = new System.Windows.Forms.RadioButton();
            this.rdbClasseWarrior = new System.Windows.Forms.RadioButton();

            this.SuspendLayout();
            // 
            // txtBoxPseudo
            // 
            this.txtBoxPseudo.BackColor = System.Drawing.Color.FloralWhite;
            this.txtBoxPseudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPseudo.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPseudo.Location = new System.Drawing.Point(156, 151);
            this.txtBoxPseudo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPseudo.MaxLength = 255;
            this.txtBoxPseudo.Name = "txtBoxPseudo";
            this.txtBoxPseudo.Size = new System.Drawing.Size(152, 15);
            this.txtBoxPseudo.TabIndex = 0;
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWho.Location = new System.Drawing.Point(174, 29);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(91, 20);
            this.lblWho.TabIndex = 4;
            this.lblWho.Text = "Who are you ?";
            this.lblWho.UseCompatibleTextRendering = true;
            this.lblWho.Click += new System.EventHandler(this.lblWho_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(182, 108);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Your name";
            this.lblName.UseCompatibleTextRendering = true;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblWhat
            // 
            this.lblWhat.AutoSize = true;
            this.lblWhat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWhat.Location = new System.Drawing.Point(706, 29);
            this.lblWhat.Name = "lblWhat";
            this.lblWhat.Size = new System.Drawing.Size(95, 20);
            this.lblWhat.TabIndex = 6;
            this.lblWhat.Text = "What are you ?";
            this.lblWhat.UseCompatibleTextRendering = true;
            this.lblWhat.Click += new System.EventHandler(this.lblWhat_Click);
            // 
            // lblClassName
            // 
            this.lblClassName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClassName.Location = new System.Drawing.Point(727, 185);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(100, 23);
            this.lblClassName.TabIndex = 9;
            this.lblClassName.Text = "Class name";
            this.lblClassName.UseCompatibleTextRendering = true;
            // 
            // rbClasseRogue
            // 
            this.rbClasseRogue.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbClasseRogue.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.rbClasseRogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbClasseRogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbClasseRogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbClasseRogue.ForeColor = System.Drawing.Color.Black;
            this.rbClasseRogue.Image = ((System.Drawing.Image)(resources.GetObject("rbClasseRogue.Image")));
            this.rbClasseRogue.Location = new System.Drawing.Point(767, 80);
            this.rbClasseRogue.Margin = new System.Windows.Forms.Padding(4);
            this.rbClasseRogue.Name = "rbClasseRogue";
            this.rbClasseRogue.Size = new System.Drawing.Size(81, 72);
            this.rbClasseRogue.TabIndex = 8;
            this.rbClasseRogue.TabStop = true;
            this.rbClasseRogue.Tag = "classe";
            this.rbClasseRogue.UseVisualStyleBackColor = true;
            this.rbClasseRogue.CheckedChanged += new System.EventHandler(this.rbClasseRogue_CheckedChanged);
            // 
            // rdClasseMage
            // 
            this.rdClasseMage.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdClasseMage.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.rdClasseMage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdClasseMage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdClasseMage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdClasseMage.ForeColor = System.Drawing.Color.Black;
            this.rdClasseMage.Image = global::Lynaar_GUI.Properties.Resources.Mage_IcoC;
            this.rdClasseMage.Location = new System.Drawing.Point(683, 80);
            this.rdClasseMage.Margin = new System.Windows.Forms.Padding(4);
            this.rdClasseMage.Name = "rdClasseMage";
            this.rdClasseMage.Size = new System.Drawing.Size(76, 72);
            this.rdClasseMage.TabIndex = 7;
            this.rdClasseMage.TabStop = true;
            this.rdClasseMage.Tag = "classe";
            this.rdClasseMage.UseVisualStyleBackColor = true;
            this.rdClasseMage.CheckedChanged += new System.EventHandler(this.rdClasseMage_CheckedChanged);
            // 
            // btnStartNewGame
            // 
            this.btnStartNewGame.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Parcho_Gris_A;
            this.btnStartNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartNewGame.ImageKey = "(aucun)";
            this.btnStartNewGame.Location = new System.Drawing.Point(413, 218);
            this.btnStartNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartNewGame.Name = "btnStartNewGame";
            this.btnStartNewGame.Size = new System.Drawing.Size(208, 59);
            this.btnStartNewGame.TabIndex = 3;
            this.btnStartNewGame.Text = "Start a new game";
            this.btnStartNewGame.UseVisualStyleBackColor = true;
            this.btnStartNewGame.Click += new System.EventHandler(this.btnStartNewGame_Click);
            // 
            // rbClasseHunter
            // 
            this.rbClasseHunter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbClasseHunter.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.rbClasseHunter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbClasseHunter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbClasseHunter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbClasseHunter.ForeColor = System.Drawing.Color.Black;
            this.rbClasseHunter.Image = global::Lynaar_GUI.Properties.Resources.Hunter_IcoC;
            this.rbClasseHunter.Location = new System.Drawing.Point(856, 80);
            this.rbClasseHunter.Margin = new System.Windows.Forms.Padding(4);
            this.rbClasseHunter.Name = "rbClasseHunter";
            this.rbClasseHunter.Size = new System.Drawing.Size(80, 72);
            this.rbClasseHunter.TabIndex = 2;
            this.rbClasseHunter.TabStop = true;
            this.rbClasseHunter.Tag = "classe";
            this.rbClasseHunter.UseVisualStyleBackColor = true;
            this.rbClasseHunter.CheckedChanged += new System.EventHandler(this.rbClasseHunter_CheckedChanged);
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
            this.rdbClasseWarrior.Location = new System.Drawing.Point(594, 80);
            this.rdbClasseWarrior.Margin = new System.Windows.Forms.Padding(4);
            this.rdbClasseWarrior.Name = "rdbClasseWarrior";
            this.rdbClasseWarrior.Size = new System.Drawing.Size(81, 72);
            this.rdbClasseWarrior.TabIndex = 1;
            this.rdbClasseWarrior.TabStop = true;
            this.rdbClasseWarrior.Tag = "classe";
            this.rdbClasseWarrior.UseVisualStyleBackColor = false;
            this.rdbClasseWarrior.CheckedChanged += new System.EventHandler(this.rdbClasseWarrior_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_LoginNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;

            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.rbClasseRogue);
            this.Controls.Add(this.rdClasseMage);
            this.Controls.Add(this.lblWhat);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWho);

            this.Controls.Add(this.btnStartNewGame);
            this.Controls.Add(this.rbClasseHunter);
            this.Controls.Add(this.rdbClasseWarrior);
            this.Controls.Add(this.txtBoxPseudo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_LoginNewGame";
            this.Size = new System.Drawing.Size(1035, 298);
            this.Load += new System.EventHandler(this.UC_LoginNewGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPseudo;
        private System.Windows.Forms.RadioButton rdbClasseWarrior;
        private System.Windows.Forms.RadioButton rbClasseHunter;
        private System.Windows.Forms.Button btnStartNewGame;

        private System.Windows.Forms.Label lblWho;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWhat;
        private System.Windows.Forms.RadioButton rdClasseMage;
        private System.Windows.Forms.RadioButton rbClasseRogue;
        private System.Windows.Forms.Label lblClassName;

    }
}
