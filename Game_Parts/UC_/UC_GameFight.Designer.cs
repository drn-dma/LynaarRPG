namespace Lynaar_GUI.Game_Parts.UC_
{
    partial class UC_GameFight
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
            this.consoleCtrl = new ConsoleControl.ConsoleControl();
            this.pnlMonster = new System.Windows.Forms.Panel();
            this.lbl_EnemyDamage = new System.Windows.Forms.Label();
            this.lbl_EnemyHealth = new System.Windows.Forms.Label();
            this.lbl_EnemyName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSpell = new System.Windows.Forms.Panel();
            this.picBox_Spell1 = new System.Windows.Forms.PictureBox();
            this.picBox_AttackBtn = new System.Windows.Forms.PictureBox();
            this.picBox_AvatarEnemy = new System.Windows.Forms.PictureBox();
            this.pnlMonster.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSpell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Spell1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AttackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AvatarEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // consoleCtrl
            // 
            this.consoleCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleCtrl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.consoleCtrl.IsInputEnabled = false;
            this.consoleCtrl.Location = new System.Drawing.Point(0, 0);
            this.consoleCtrl.Name = "consoleCtrl";
            this.consoleCtrl.SendKeyboardCommandsToProcess = false;
            this.consoleCtrl.ShowDiagnostics = false;
            this.consoleCtrl.Size = new System.Drawing.Size(769, 405);
            this.consoleCtrl.TabIndex = 0;
            // 
            // pnlMonster
            // 
            this.pnlMonster.Controls.Add(this.lbl_EnemyDamage);
            this.pnlMonster.Controls.Add(this.lbl_EnemyHealth);
            this.pnlMonster.Controls.Add(this.lbl_EnemyName);
            this.pnlMonster.Controls.Add(this.picBox_AvatarEnemy);
            this.pnlMonster.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMonster.Location = new System.Drawing.Point(769, 0);
            this.pnlMonster.Name = "pnlMonster";
            this.pnlMonster.Size = new System.Drawing.Size(313, 548);
            this.pnlMonster.TabIndex = 1;
            // 
            // lbl_EnemyDamage
            // 
            this.lbl_EnemyDamage.AutoSize = true;
            this.lbl_EnemyDamage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_EnemyDamage.Location = new System.Drawing.Point(120, 337);
            this.lbl_EnemyDamage.Name = "lbl_EnemyDamage";
            this.lbl_EnemyDamage.Size = new System.Drawing.Size(85, 13);
            this.lbl_EnemyDamage.TabIndex = 3;
            this.lbl_EnemyDamage.Text = "EnemeyDamage";
            // 
            // lbl_EnemyHealth
            // 
            this.lbl_EnemyHealth.AutoSize = true;
            this.lbl_EnemyHealth.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_EnemyHealth.Location = new System.Drawing.Point(120, 305);
            this.lbl_EnemyHealth.Name = "lbl_EnemyHealth";
            this.lbl_EnemyHealth.Size = new System.Drawing.Size(70, 13);
            this.lbl_EnemyHealth.TabIndex = 2;
            this.lbl_EnemyHealth.Text = "EnemyHealth";
            // 
            // lbl_EnemyName
            // 
            this.lbl_EnemyName.AutoSize = true;
            this.lbl_EnemyName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_EnemyName.Location = new System.Drawing.Point(120, 246);
            this.lbl_EnemyName.Name = "lbl_EnemyName";
            this.lbl_EnemyName.Size = new System.Drawing.Size(67, 13);
            this.lbl_EnemyName.TabIndex = 1;
            this.lbl_EnemyName.Text = "EnemyName";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.consoleCtrl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 405);
            this.panel2.TabIndex = 2;
            // 
            // pnlSpell
            // 
            this.pnlSpell.Controls.Add(this.picBox_Spell1);
            this.pnlSpell.Controls.Add(this.picBox_AttackBtn);
            this.pnlSpell.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSpell.Location = new System.Drawing.Point(0, 405);
            this.pnlSpell.Name = "pnlSpell";
            this.pnlSpell.Size = new System.Drawing.Size(769, 143);
            this.pnlSpell.TabIndex = 4;
            // 
            // picBox_Spell1
            // 
            this.picBox_Spell1.Location = new System.Drawing.Point(420, 43);
            this.picBox_Spell1.Name = "picBox_Spell1";
            this.picBox_Spell1.Size = new System.Drawing.Size(64, 64);
            this.picBox_Spell1.TabIndex = 1;
            this.picBox_Spell1.TabStop = false;
            // 
            // picBox_AttackBtn
            // 
            this.picBox_AttackBtn.Location = new System.Drawing.Point(275, 43);
            this.picBox_AttackBtn.Name = "picBox_AttackBtn";
            this.picBox_AttackBtn.Size = new System.Drawing.Size(64, 64);
            this.picBox_AttackBtn.TabIndex = 0;
            this.picBox_AttackBtn.TabStop = false;
            this.picBox_AttackBtn.Click += new System.EventHandler(this.attack);
            // 
            // picBox_AvatarEnemy
            // 
            this.picBox_AvatarEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_AvatarEnemy.Location = new System.Drawing.Point(59, 43);
            this.picBox_AvatarEnemy.Name = "picBox_AvatarEnemy";
            this.picBox_AvatarEnemy.Size = new System.Drawing.Size(200, 200);
            this.picBox_AvatarEnemy.TabIndex = 0;
            this.picBox_AvatarEnemy.TabStop = false;
            // 
            // UC_GameFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSpell);
            this.Controls.Add(this.pnlMonster);
            this.Name = "UC_GameFight";
            this.Size = new System.Drawing.Size(1082, 548);
            this.Load += new System.EventHandler(this.UC_GameFight_Load);
            this.pnlMonster.ResumeLayout(false);
            this.pnlMonster.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlSpell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Spell1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AttackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AvatarEnemy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ConsoleControl.ConsoleControl consoleCtrl;
        private System.Windows.Forms.Panel pnlMonster;
        private System.Windows.Forms.PictureBox picBox_AvatarEnemy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSpell;
        private System.Windows.Forms.Label lbl_EnemyDamage;
        private System.Windows.Forms.Label lbl_EnemyHealth;
        private System.Windows.Forms.Label lbl_EnemyName;
        private System.Windows.Forms.PictureBox picBox_Spell1;
        private System.Windows.Forms.PictureBox picBox_AttackBtn;
    }
}
