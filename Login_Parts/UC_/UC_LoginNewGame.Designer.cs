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
            this.txtBoxPseudo = new System.Windows.Forms.TextBox();
            this.rdbClasseWarrior = new System.Windows.Forms.RadioButton();
            this.rbClasseHunter = new System.Windows.Forms.RadioButton();
            this.btnStartNewGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxPseudo
            // 
            this.txtBoxPseudo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxPseudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPseudo.ForeColor = System.Drawing.Color.White;
            this.txtBoxPseudo.Location = new System.Drawing.Point(189, 75);
            this.txtBoxPseudo.MaxLength = 255;
            this.txtBoxPseudo.Name = "txtBoxPseudo";
            this.txtBoxPseudo.Size = new System.Drawing.Size(114, 13);
            this.txtBoxPseudo.TabIndex = 0;
            // 
            // rdbClasseWarrior
            // 
            this.rdbClasseWarrior.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbClasseWarrior.AutoSize = true;
            this.rdbClasseWarrior.ForeColor = System.Drawing.Color.Black;
            this.rdbClasseWarrior.Location = new System.Drawing.Point(475, 70);
            this.rdbClasseWarrior.Name = "rdbClasseWarrior";
            this.rdbClasseWarrior.Size = new System.Drawing.Size(51, 23);
            this.rdbClasseWarrior.TabIndex = 1;
            this.rdbClasseWarrior.TabStop = true;
            this.rdbClasseWarrior.Tag = "classe";
            this.rdbClasseWarrior.Text = "Warrior";
            this.rdbClasseWarrior.UseVisualStyleBackColor = true;
            // 
            // rbClasseHunter
            // 
            this.rbClasseHunter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbClasseHunter.AutoSize = true;
            this.rbClasseHunter.ForeColor = System.Drawing.Color.Black;
            this.rbClasseHunter.Location = new System.Drawing.Point(475, 109);
            this.rbClasseHunter.Name = "rbClasseHunter";
            this.rbClasseHunter.Size = new System.Drawing.Size(49, 23);
            this.rbClasseHunter.TabIndex = 2;
            this.rbClasseHunter.TabStop = true;
            this.rbClasseHunter.Tag = "classe";
            this.rbClasseHunter.Text = "Hunter";
            this.rbClasseHunter.UseVisualStyleBackColor = true;
            // 
            // btnStartNewGame
            // 
            this.btnStartNewGame.Location = new System.Drawing.Point(375, 166);
            this.btnStartNewGame.Name = "btnStartNewGame";
            this.btnStartNewGame.Size = new System.Drawing.Size(110, 30);
            this.btnStartNewGame.TabIndex = 3;
            this.btnStartNewGame.Text = "Start a new game";
            this.btnStartNewGame.UseVisualStyleBackColor = true;
            this.btnStartNewGame.Click += new System.EventHandler(this.btnStartNewGame_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStartNewGame);
            this.Controls.Add(this.rbClasseHunter);
            this.Controls.Add(this.rdbClasseWarrior);
            this.Controls.Add(this.txtBoxPseudo);
            this.Name = "UC_LoginNewGame";
            this.Size = new System.Drawing.Size(776, 242);
            this.Load += new System.EventHandler(this.UC_LoginNewGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPseudo;
        private System.Windows.Forms.RadioButton rdbClasseWarrior;
        private System.Windows.Forms.RadioButton rbClasseHunter;
        private System.Windows.Forms.Button btnStartNewGame;
        private System.Windows.Forms.Button button1;
    }
}
