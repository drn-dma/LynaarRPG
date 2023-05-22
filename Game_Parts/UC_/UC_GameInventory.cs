using Lynaar_GUI.Classes;
using Lynaar_GUI.Game_Parts.UC_.Items;
using Lynaar_GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI
{
    public partial class UC_GameInventory : UserControl
    {
        #region Attributs

        private Font font40;

        private Player player;

        internal Player Player { get => player; set => player = value; }
        #endregion

        public UC_GameInventory(GameForm parentForm)
        {
            InitializeComponent();

            //! Initialisation de la police de caractère
            this.font40 = new Font(FunctionsLibs.Font_Alkhemikal, 40);
            this.table_Inventory.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.table_Inventory.Visible = true;
            this.table_Inventory.Refresh();

            this.player = parentForm.CurrentPlayer;
        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            //! Modification de la police de caractère du label 'lbl_Inventaire' au chargement de l'UC
            this.lbl_Inventaire.Font = font40;
           

            int i = 1;

            foreach (var equipement in SQLConnect.getPlayerEquipement(this.player.Id))
            {
                string panelName = "pnl_Item" + i;
                Panel panel = (Panel)Controls.Find(panelName,true).FirstOrDefault();
                UC_ItemAndQuantity uc = new UC_ItemAndQuantity(int.Parse(equipement["Id_Equipement"].ToString()));
                uc.Player = this.player;
                uc.InventoryPanel = this;
                FunctionsLibs.add_UControls(uc,panel);
                i++;
            }

            foreach(var Consommable in SQLConnect.getPlayerConsumable(this.player.Id))
            {
                string panelName = "pnl_Item" + i;
                Panel panel = (Panel)Controls.Find(panelName, true).FirstOrDefault();
                UC_ItemAndQuantity uc = new UC_ItemAndQuantity(int.Parse(Consommable["Id_Consumables"].ToString()), int.Parse(Consommable["quantity"].ToString()));
                uc.Player = this.player;
                uc.InventoryPanel = this;
                FunctionsLibs.add_UControls(uc, panel);
                i++;
            }

        }

        private void picBox_EquiWeapon_Click(object sender, EventArgs e)
        {

        }
    }
}
