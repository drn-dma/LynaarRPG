namespace Lynaar_GUI
{
    partial class GameForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pnl_TabControl = new System.Windows.Forms.Panel();
            this.table_MenuButton = new System.Windows.Forms.TableLayoutPanel();
            this.picBox_Inventory = new System.Windows.Forms.PictureBox();
            this.picBox_Home = new System.Windows.Forms.PictureBox();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_PlayerInfo = new System.Windows.Forms.Panel();
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            this.lblXp = new System.Windows.Forms.Label();
            this.pBarHp = new System.Windows.Forms.ProgressBar();
            this.pBarXp = new System.Windows.Forms.ProgressBar();
            this.lblNextBossFloor = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.picBoxNextBossFloor = new System.Windows.Forms.PictureBox();
            this.picBoxFloor = new System.Windows.Forms.PictureBox();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblAtk = new System.Windows.Forms.Label();
            this.lblIntAndEnd = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picBoxXp = new System.Windows.Forms.PictureBox();
            this.picBoxIntAndEnd = new System.Windows.Forms.PictureBox();
            this.picBoxGold = new System.Windows.Forms.PictureBox();
            this.picBoxAtk = new System.Windows.Forms.PictureBox();
            this.picBoxHp = new System.Windows.Forms.PictureBox();
            this.picBoxFondAvatar = new System.Windows.Forms.PictureBox();
            this.pnl_TabControl.SuspendLayout();
            this.table_MenuButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Home)).BeginInit();
            this.pnl_PlayerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNextBossFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxXp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIntAndEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFondAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1685, 92);
            this.pnl_Top.TabIndex = 0;
            this.pnl_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Top_Paint);
            // 
            // pnl_TabControl
            // 
            this.pnl_TabControl.Controls.Add(this.table_MenuButton);
            this.pnl_TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TabControl.Location = new System.Drawing.Point(243, 92);
            this.pnl_TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_TabControl.Name = "pnl_TabControl";
            this.pnl_TabControl.Size = new System.Drawing.Size(1442, 71);
            this.pnl_TabControl.TabIndex = 2;
            // 
            // table_MenuButton
            // 
            this.table_MenuButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.table_MenuButton.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.table_MenuButton.ColumnCount = 3;
            this.table_MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.table_MenuButton.Controls.Add(this.picBox_Inventory, 1, 0);
            this.table_MenuButton.Controls.Add(this.picBox_Home, 0, 0);
            this.table_MenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_MenuButton.Location = new System.Drawing.Point(0, 0);
            this.table_MenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.table_MenuButton.Name = "table_MenuButton";
            this.table_MenuButton.RowCount = 1;
            this.table_MenuButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_MenuButton.Size = new System.Drawing.Size(1442, 71);
            this.table_MenuButton.TabIndex = 0;
            this.table_MenuButton.Paint += new System.Windows.Forms.PaintEventHandler(this.table_MenuButton_Paint);
            // 
            // picBox_Inventory
            // 
            this.picBox_Inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_Inventory.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Inventory.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Inventory_Ico;
            this.picBox_Inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_Inventory.Location = new System.Drawing.Point(151, 6);
            this.picBox_Inventory.Margin = new System.Windows.Forms.Padding(4);
            this.picBox_Inventory.Name = "picBox_Inventory";
            this.picBox_Inventory.Size = new System.Drawing.Size(135, 59);
            this.picBox_Inventory.TabIndex = 0;
            this.picBox_Inventory.TabStop = false;
            this.picBox_Inventory.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // picBox_Home
            // 
            this.picBox_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_Home.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Home.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Home_Ico;
            this.picBox_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_Home.Location = new System.Drawing.Point(6, 6);
            this.picBox_Home.Margin = new System.Windows.Forms.Padding(4);
            this.picBox_Home.Name = "picBox_Home";
            this.picBox_Home.Size = new System.Drawing.Size(135, 59);
            this.picBox_Home.TabIndex = 1;
            this.picBox_Home.TabStop = false;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(243, 163);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1442, 675);
            this.pnl_Main.TabIndex = 3;
            this.pnl_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Main_Paint);
            // 
            // pnl_PlayerInfo
            // 
            this.pnl_PlayerInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnl_PlayerInfo.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondPlayerPanel;
            this.pnl_PlayerInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_PlayerInfo.Controls.Add(this.picBoxAvatar);
            this.pnl_PlayerInfo.Controls.Add(this.lblXp);
            this.pnl_PlayerInfo.Controls.Add(this.pBarHp);
            this.pnl_PlayerInfo.Controls.Add(this.pBarXp);
            this.pnl_PlayerInfo.Controls.Add(this.lblNextBossFloor);
            this.pnl_PlayerInfo.Controls.Add(this.lblFloor);
            this.pnl_PlayerInfo.Controls.Add(this.picBoxNextBossFloor);
            this.pnl_PlayerInfo.Controls.Add(this.picBoxFloor);
            this.pnl_PlayerInfo.Controls.Add(this.lblGold);
            this.pnl_PlayerInfo.Controls.Add(this.lblLevel);
            this.pnl_PlayerInfo.Controls.Add(this.lblAtk);
            this.pnl_PlayerInfo.Controls.Add(this.lblIntAndEnd);
            this.pnl_PlayerInfo.Controls.Add(this.lblHp);
            this.pnl_PlayerInfo.Controls.Add(this.lblName);
            this.pnl_PlayerInfo.Controls.Add(this.picBoxXp);
            this.pnl_PlayerInfo.Controls.Add(this.picBoxIntAndEnd);
            this.pnl_PlayerInfo.Controls.Add(this.picBoxGold);
            this.pnl_PlayerInfo.Controls.Add(this.picBoxAtk);
            this.pnl_PlayerInfo.Controls.Add(this.picBoxHp);
            this.pnl_PlayerInfo.Controls.Add(this.picBoxFondAvatar);
            this.pnl_PlayerInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_PlayerInfo.Location = new System.Drawing.Point(0, 92);
            this.pnl_PlayerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_PlayerInfo.Name = "pnl_PlayerInfo";
            this.pnl_PlayerInfo.Size = new System.Drawing.Size(243, 746);
            this.pnl_PlayerInfo.TabIndex = 1;
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAvatar.Location = new System.Drawing.Point(32, 127);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Size = new System.Drawing.Size(180, 180);
            this.picBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAvatar.TabIndex = 20;
            this.picBoxAvatar.TabStop = false;
            // 
            // lblXp
            // 
            this.lblXp.AutoSize = true;
            this.lblXp.BackColor = System.Drawing.Color.Transparent;
            this.lblXp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblXp.Location = new System.Drawing.Point(57, 680);
            this.lblXp.Name = "lblXp";
            this.lblXp.Size = new System.Drawing.Size(35, 20);
            this.lblXp.TabIndex = 19;
            this.lblXp.Text = "lblXp";
            this.lblXp.UseCompatibleTextRendering = true;
            // 
            // pBarHp
            // 
            this.pBarHp.ForeColor = System.Drawing.Color.Firebrick;
            this.pBarHp.Location = new System.Drawing.Point(21, 395);
            this.pBarHp.Name = "pBarHp";
            this.pBarHp.RightToLeftLayout = true;
            this.pBarHp.Size = new System.Drawing.Size(201, 23);
            this.pBarHp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBarHp.TabIndex = 18;
            this.pBarHp.Value = 100;
            // 
            // pBarXp
            // 
            this.pBarXp.ForeColor = System.Drawing.Color.DarkViolet;
            this.pBarXp.Location = new System.Drawing.Point(21, 711);
            this.pBarXp.Name = "pBarXp";
            this.pBarXp.Size = new System.Drawing.Size(200, 23);
            this.pBarXp.TabIndex = 17;
            // 
            // lblNextBossFloor
            // 
            this.lblNextBossFloor.AutoSize = true;
            this.lblNextBossFloor.BackColor = System.Drawing.Color.Transparent;
            this.lblNextBossFloor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNextBossFloor.Location = new System.Drawing.Point(180, 510);
            this.lblNextBossFloor.Name = "lblNextBossFloor";
            this.lblNextBossFloor.Size = new System.Drawing.Size(106, 20);
            this.lblNextBossFloor.TabIndex = 16;
            this.lblNextBossFloor.Text = "lblNextBossFloor";
            this.lblNextBossFloor.UseCompatibleTextRendering = true;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.BackColor = System.Drawing.Color.Transparent;
            this.lblFloor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFloor.Location = new System.Drawing.Point(59, 510);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(49, 20);
            this.lblFloor.TabIndex = 15;
            this.lblFloor.Text = "lblFloor";
            this.lblFloor.UseCompatibleTextRendering = true;
            // 
            // picBoxNextBossFloor
            // 
            this.picBoxNextBossFloor.BackColor = System.Drawing.Color.Transparent;
            this.picBoxNextBossFloor.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Boss_Ico_x32;
            this.picBoxNextBossFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxNextBossFloor.Location = new System.Drawing.Point(142, 505);
            this.picBoxNextBossFloor.Name = "picBoxNextBossFloor";
            this.picBoxNextBossFloor.Size = new System.Drawing.Size(32, 32);
            this.picBoxNextBossFloor.TabIndex = 14;
            this.picBoxNextBossFloor.TabStop = false;
            // 
            // picBoxFloor
            // 
            this.picBoxFloor.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFloor.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Floor_Ico_x32;
            this.picBoxFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxFloor.Location = new System.Drawing.Point(21, 505);
            this.picBoxFloor.Name = "picBoxFloor";
            this.picBoxFloor.Size = new System.Drawing.Size(32, 32);
            this.picBoxFloor.TabIndex = 13;
            this.picBoxFloor.TabStop = false;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BackColor = System.Drawing.Color.Transparent;
            this.lblGold.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGold.Location = new System.Drawing.Point(59, 632);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(47, 20);
            this.lblGold.TabIndex = 12;
            this.lblGold.Text = "lblGold";
            this.lblGold.UseCompatibleTextRendering = true;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLevel.Location = new System.Drawing.Point(134, 347);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(50, 20);
            this.lblLevel.TabIndex = 11;
            this.lblLevel.Text = "lblLevel";
            this.lblLevel.UseCompatibleTextRendering = true;
            // 
            // lblAtk
            // 
            this.lblAtk.AutoSize = true;
            this.lblAtk.BackColor = System.Drawing.Color.Transparent;
            this.lblAtk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAtk.Location = new System.Drawing.Point(180, 448);
            this.lblAtk.Name = "lblAtk";
            this.lblAtk.Size = new System.Drawing.Size(38, 20);
            this.lblAtk.TabIndex = 10;
            this.lblAtk.Text = "lblAtk";
            this.lblAtk.UseCompatibleTextRendering = true;
            // 
            // lblIntAndEnd
            // 
            this.lblIntAndEnd.AutoSize = true;
            this.lblIntAndEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblIntAndEnd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIntAndEnd.Location = new System.Drawing.Point(61, 448);
            this.lblIntAndEnd.Name = "lblIntAndEnd";
            this.lblIntAndEnd.Size = new System.Drawing.Size(81, 20);
            this.lblIntAndEnd.TabIndex = 9;
            this.lblIntAndEnd.Text = "lblIntAndEnd";
            this.lblIntAndEnd.UseCompatibleTextRendering = true;
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.BackColor = System.Drawing.Color.Transparent;
            this.lblHp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHp.Location = new System.Drawing.Point(57, 347);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(35, 20);
            this.lblHp.TabIndex = 8;
            this.lblHp.Text = "lblHp";
            this.lblHp.UseCompatibleTextRendering = true;
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(21, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(201, 35);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "lblName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.UseCompatibleTextRendering = true;
            // 
            // picBoxXp
            // 
            this.picBoxXp.BackColor = System.Drawing.Color.Transparent;
            this.picBoxXp.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Xp_Ico_x32;
            this.picBoxXp.Location = new System.Drawing.Point(21, 673);
            this.picBoxXp.Name = "picBoxXp";
            this.picBoxXp.Size = new System.Drawing.Size(32, 32);
            this.picBoxXp.TabIndex = 6;
            this.picBoxXp.TabStop = false;
            // 
            // picBoxIntAndEnd
            // 
            this.picBoxIntAndEnd.BackColor = System.Drawing.Color.Transparent;
            this.picBoxIntAndEnd.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Endure32_Ico;
            this.picBoxIntAndEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxIntAndEnd.Location = new System.Drawing.Point(21, 441);
            this.picBoxIntAndEnd.Name = "picBoxIntAndEnd";
            this.picBoxIntAndEnd.Size = new System.Drawing.Size(32, 32);
            this.picBoxIntAndEnd.TabIndex = 5;
            this.picBoxIntAndEnd.TabStop = false;
            // 
            // picBoxGold
            // 
            this.picBoxGold.BackColor = System.Drawing.Color.Transparent;
            this.picBoxGold.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Gold_Ico_x32;
            this.picBoxGold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxGold.Location = new System.Drawing.Point(21, 626);
            this.picBoxGold.Name = "picBoxGold";
            this.picBoxGold.Size = new System.Drawing.Size(32, 32);
            this.picBoxGold.TabIndex = 3;
            this.picBoxGold.TabStop = false;
            // 
            // picBoxAtk
            // 
            this.picBoxAtk.BackColor = System.Drawing.Color.Transparent;
            this.picBoxAtk.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Atk32_Ico;
            this.picBoxAtk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxAtk.Location = new System.Drawing.Point(142, 441);
            this.picBoxAtk.Name = "picBoxAtk";
            this.picBoxAtk.Size = new System.Drawing.Size(32, 32);
            this.picBoxAtk.TabIndex = 2;
            this.picBoxAtk.TabStop = false;
            // 
            // picBoxHp
            // 
            this.picBoxHp.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHp.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Hp32_Ico;
            this.picBoxHp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxHp.Location = new System.Drawing.Point(21, 340);
            this.picBoxHp.Name = "picBoxHp";
            this.picBoxHp.Size = new System.Drawing.Size(32, 32);
            this.picBoxHp.TabIndex = 1;
            this.picBoxHp.TabStop = false;
            // 
            // picBoxFondAvatar
            // 
            this.picBoxFondAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFondAvatar.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Cadre_Avatar;
            this.picBoxFondAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxFondAvatar.Location = new System.Drawing.Point(27, 122);
            this.picBoxFondAvatar.Name = "picBoxFondAvatar";
            this.picBoxFondAvatar.Size = new System.Drawing.Size(190, 190);
            this.picBoxFondAvatar.TabIndex = 0;
            this.picBoxFondAvatar.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_TabControl);
            this.Controls.Add(this.pnl_PlayerInfo);
            this.Controls.Add(this.pnl_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "Lynaar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_TabControl.ResumeLayout(false);
            this.table_MenuButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Home)).EndInit();
            this.pnl_PlayerInfo.ResumeLayout(false);
            this.pnl_PlayerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNextBossFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxXp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIntAndEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFondAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel pnl_PlayerInfo;
        private System.Windows.Forms.Panel pnl_TabControl;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.TableLayoutPanel table_MenuButton;
        private System.Windows.Forms.PictureBox picBox_Inventory;
        private System.Windows.Forms.PictureBox picBox_Home;
        private System.Windows.Forms.PictureBox picBoxFondAvatar;
        private System.Windows.Forms.ProgressBar pBarHp;
        private System.Windows.Forms.ProgressBar pBarXp;
        private System.Windows.Forms.Label lblNextBossFloor;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.PictureBox picBoxNextBossFloor;
        private System.Windows.Forms.PictureBox picBoxFloor;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblAtk;
        private System.Windows.Forms.Label lblIntAndEnd;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picBoxXp;
        private System.Windows.Forms.PictureBox picBoxIntAndEnd;
        private System.Windows.Forms.PictureBox picBoxAtk;
        private System.Windows.Forms.PictureBox picBoxHp;
        private System.Windows.Forms.Label lblXp;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.PictureBox picBoxGold;
        private System.Windows.Forms.PictureBox picBoxAvatar;
    }
}

