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

        private List<Dictionary<string, object>> equip_Inventory;

        #endregion

        public UC_GameInventory()
        {
            InitializeComponent();

            //! Initialisation de la police de caractère
            this.font40 = new Font(FunctionsLibs.Font_Alkhemikal, 40);
            this.table_Inventory.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.table_Inventory.Visible = true;
            this.table_Inventory.Refresh();
        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            //! Modification de la police de caractère du label 'lbl_Inventaire' au chargement de l'UC
            this.lbl_Inventaire.Font = font40;

            //todo Améliorer cette partie pour mélanger equipement et consommable et mettre Id_Player variable

            equip_Inventory = SQLConnect.readDataFromSQL($"SELECT * FROM Inventory_Equipement WHERE Id_Player = 2");

            int i = 1;

            foreach (var equipement in equip_Inventory)
            {
                string panelName = "pnl_Item" + i;
                Panel panel = (Panel)Controls.Find(panelName,true).FirstOrDefault();
                FunctionsLibs.add_UControls(new UC_ItemAndQuantity(int.Parse(equipement["Id_Equipement"].ToString())),panel);
                i++;
            }


        }

    }
}
