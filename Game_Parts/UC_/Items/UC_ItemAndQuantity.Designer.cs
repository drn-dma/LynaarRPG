namespace Lynaar_GUI.Game_Parts.UC_.Items
{
    partial class UC_ItemAndQuantity
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
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.picBox_Item = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Quantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Quantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Quantity.Location = new System.Drawing.Point(0, 0);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Quantity.Size = new System.Drawing.Size(29, 17);
            this.lbl_Quantity.TabIndex = 0;
            this.lbl_Quantity.Text = "9999";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_Quantity.UseCompatibleTextRendering = true;
            // 
            // picBox_Item
            // 
            this.picBox_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Item.Location = new System.Drawing.Point(3, 3);
            this.picBox_Item.Name = "picBox_Item";
            this.picBox_Item.Size = new System.Drawing.Size(52, 52);
            this.picBox_Item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Item.TabIndex = 1;
            this.picBox_Item.TabStop = false;
            this.picBox_Item.Click += new System.EventHandler(this.onItemClick);
            // 
            // UC_ItemAndQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Lynaar_GUI.Properties.Resources.FondClass_Ico;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.picBox_Item);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_ItemAndQuantity";
            this.Size = new System.Drawing.Size(58, 58);
            this.Load += new System.EventHandler(this.UC_ItemAndQuantity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.PictureBox picBox_Item;
    }
}
