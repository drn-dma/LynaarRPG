﻿namespace Lynaar_GUI.Login_Parts.UC_
{
    partial class UC_LoginMainMenu
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
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_LoadGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewGame.ForeColor = System.Drawing.Color.White;
            this.btn_NewGame.Location = new System.Drawing.Point(375, 71);
            this.btn_NewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(285, 49);
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            this.btn_NewGame.MouseLeave += new System.EventHandler(this.exitHoverBtn);
            this.btn_NewGame.MouseHover += new System.EventHandler(this.hoverBtn);
            // 
            // btn_LoadGame
            // 
            this.btn_LoadGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LoadGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadGame.ForeColor = System.Drawing.Color.White;
            this.btn_LoadGame.Location = new System.Drawing.Point(375, 155);
            this.btn_LoadGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LoadGame.Name = "btn_LoadGame";
            this.btn_LoadGame.Size = new System.Drawing.Size(285, 49);
            this.btn_LoadGame.TabIndex = 1;
            this.btn_LoadGame.Text = "Load Game";
            this.btn_LoadGame.UseVisualStyleBackColor = true;
            this.btn_LoadGame.MouseEnter += new System.EventHandler(this.hoverBtn);
            this.btn_LoadGame.MouseLeave += new System.EventHandler(this.exitHoverBtn);
            // 
            // UC_LoginMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btn_LoadGame);
            this.Controls.Add(this.btn_NewGame);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_LoginMainMenu";
            this.Size = new System.Drawing.Size(1035, 298);
            this.Load += new System.EventHandler(this.UC_LoginMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_LoadGame;
    }
}
