namespace Lynaar_GUI
{
    partial class UC_GameInventory
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
            this.pnl_InventoryTitle = new System.Windows.Forms.Panel();
            this.lbl_Inventaire = new System.Windows.Forms.Label();
            this.pnl_PlayerEquipement = new System.Windows.Forms.Panel();
            this.pnl_Inventory = new System.Windows.Forms.Panel();
            this.table_Inventory = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_ItemInfo = new System.Windows.Forms.Panel();
            this.pnl_InventoryTitle.SuspendLayout();
            this.pnl_Inventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_InventoryTitle
            // 
            this.pnl_InventoryTitle.Controls.Add(this.lbl_Inventaire);
            this.pnl_InventoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_InventoryTitle.Location = new System.Drawing.Point(0, 0);
            this.pnl_InventoryTitle.Name = "pnl_InventoryTitle";
            this.pnl_InventoryTitle.Size = new System.Drawing.Size(1082, 77);
            this.pnl_InventoryTitle.TabIndex = 0;
            // 
            // lbl_Inventaire
            // 
            this.lbl_Inventaire.AutoSize = true;
            this.lbl_Inventaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inventaire.Location = new System.Drawing.Point(151, 12);
            this.lbl_Inventaire.Name = "lbl_Inventaire";
            this.lbl_Inventaire.Size = new System.Drawing.Size(208, 57);
            this.lbl_Inventaire.TabIndex = 0;
            this.lbl_Inventaire.Text = "Inventaire";
            this.lbl_Inventaire.UseCompatibleTextRendering = true;
            this.lbl_Inventaire.Click += new System.EventHandler(this.lbl_Inventaire_Click);
            // 
            // pnl_PlayerEquipement
            // 
            this.pnl_PlayerEquipement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_PlayerEquipement.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_PlayerEquipement.Location = new System.Drawing.Point(810, 77);
            this.pnl_PlayerEquipement.Name = "pnl_PlayerEquipement";
            this.pnl_PlayerEquipement.Size = new System.Drawing.Size(272, 471);
            this.pnl_PlayerEquipement.TabIndex = 1;
            // 
            // pnl_Inventory
            // 
            this.pnl_Inventory.Controls.Add(this.table_Inventory);
            this.pnl_Inventory.Controls.Add(this.pnl_ItemInfo);
            this.pnl_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Inventory.Location = new System.Drawing.Point(0, 77);
            this.pnl_Inventory.Name = "pnl_Inventory";
            this.pnl_Inventory.Size = new System.Drawing.Size(810, 471);
            this.pnl_Inventory.TabIndex = 2;
            // 
            // table_Inventory
            // 
            this.table_Inventory.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.table_Inventory.ColumnCount = 13;
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.table_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Inventory.Location = new System.Drawing.Point(0, 0);
            this.table_Inventory.Name = "table_Inventory";
            this.table_Inventory.RowCount = 5;
            this.table_Inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.table_Inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.table_Inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_Inventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_Inventory.Size = new System.Drawing.Size(810, 274);
            this.table_Inventory.TabIndex = 0;
            // 
            // pnl_ItemInfo
            // 
            this.pnl_ItemInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_ItemInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_ItemInfo.Location = new System.Drawing.Point(0, 274);
            this.pnl_ItemInfo.Name = "pnl_ItemInfo";
            this.pnl_ItemInfo.Size = new System.Drawing.Size(810, 197);
            this.pnl_ItemInfo.TabIndex = 1;
            // 
            // UC_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Inventory);
            this.Controls.Add(this.pnl_PlayerEquipement);
            this.Controls.Add(this.pnl_InventoryTitle);
            this.Name = "UC_Inventory";
            this.Size = new System.Drawing.Size(1082, 548);
            this.Load += new System.EventHandler(this.UC_Inventory_Load);
            this.pnl_InventoryTitle.ResumeLayout(false);
            this.pnl_InventoryTitle.PerformLayout();
            this.pnl_Inventory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_InventoryTitle;
        private System.Windows.Forms.Label lbl_Inventaire;
        private System.Windows.Forms.Panel pnl_PlayerEquipement;
        private System.Windows.Forms.Panel pnl_Inventory;
        private System.Windows.Forms.Panel pnl_ItemInfo;
        private System.Windows.Forms.TableLayoutPanel table_Inventory;
    }
}
