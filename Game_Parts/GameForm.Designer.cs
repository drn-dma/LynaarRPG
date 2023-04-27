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
            this.pnl_PlayerInfo = new System.Windows.Forms.Panel();
            this.pic_ClasseIcon = new System.Windows.Forms.PictureBox();
            this.pnl_TabControl = new System.Windows.Forms.Panel();
            this.table_MenuButton = new System.Windows.Forms.TableLayoutPanel();
            this.picBox_Inventory = new System.Windows.Forms.PictureBox();
            this.picBox_Home = new System.Windows.Forms.PictureBox();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_PlayerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ClasseIcon)).BeginInit();
            this.pnl_TabControl.SuspendLayout();
            this.table_MenuButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1264, 75);
            this.pnl_Top.TabIndex = 0;
            // 
            // pnl_PlayerInfo
            // 
            this.pnl_PlayerInfo.Controls.Add(this.pic_ClasseIcon);
            this.pnl_PlayerInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_PlayerInfo.Location = new System.Drawing.Point(0, 75);
            this.pnl_PlayerInfo.Name = "pnl_PlayerInfo";
            this.pnl_PlayerInfo.Size = new System.Drawing.Size(182, 606);
            this.pnl_PlayerInfo.TabIndex = 1;
            // 
            // pic_ClasseIcon
            // 
            this.pic_ClasseIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_ClasseIcon.Location = new System.Drawing.Point(9, 20);
            this.pic_ClasseIcon.Name = "pic_ClasseIcon";
            this.pic_ClasseIcon.Size = new System.Drawing.Size(164, 164);
            this.pic_ClasseIcon.TabIndex = 0;
            this.pic_ClasseIcon.TabStop = false;
            // 
            // pnl_TabControl
            // 
            this.pnl_TabControl.Controls.Add(this.table_MenuButton);
            this.pnl_TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TabControl.Location = new System.Drawing.Point(182, 75);
            this.pnl_TabControl.Name = "pnl_TabControl";
            this.pnl_TabControl.Size = new System.Drawing.Size(1082, 58);
            this.pnl_TabControl.TabIndex = 2;
            // 
            // table_MenuButton
            // 
            this.table_MenuButton.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.table_MenuButton.ColumnCount = 3;
            this.table_MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_MenuButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.table_MenuButton.Controls.Add(this.picBox_Inventory, 1, 0);
            this.table_MenuButton.Controls.Add(this.picBox_Home, 0, 0);
            this.table_MenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_MenuButton.Location = new System.Drawing.Point(0, 0);
            this.table_MenuButton.Name = "table_MenuButton";
            this.table_MenuButton.RowCount = 1;
            this.table_MenuButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_MenuButton.Size = new System.Drawing.Size(1082, 58);
            this.table_MenuButton.TabIndex = 0;
            // 
            // picBox_Inventory
            // 
            this.picBox_Inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_Inventory.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Inventory.BackgroundImage = global::Lynaar_GUI.Properties.Resources.Inventory_Ico;
            this.picBox_Inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_Inventory.Location = new System.Drawing.Point(114, 5);
            this.picBox_Inventory.Name = "picBox_Inventory";
            this.picBox_Inventory.Size = new System.Drawing.Size(101, 48);
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
            this.picBox_Home.Location = new System.Drawing.Point(5, 5);
            this.picBox_Home.Name = "picBox_Home";
            this.picBox_Home.Size = new System.Drawing.Size(101, 48);
            this.picBox_Home.TabIndex = 1;
            this.picBox_Home.TabStop = false;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(182, 133);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1082, 548);
            this.pnl_Main.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_TabControl);
            this.Controls.Add(this.pnl_PlayerInfo);
            this.Controls.Add(this.pnl_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lynaar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_PlayerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ClasseIcon)).EndInit();
            this.pnl_TabControl.ResumeLayout(false);
            this.table_MenuButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Home)).EndInit();
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
        private System.Windows.Forms.PictureBox pic_ClasseIcon;
    }
}

