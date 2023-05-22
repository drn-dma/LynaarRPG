using System;
using Lynaar_GUI.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Game_Parts.UC_.Items
{
    public partial class UC_ItemAndQuantity : UserControl
    {
        private int idItem;
        private int quantity;

        private PictureBox equipedWeapon;
        private PictureBox equipedArmor;
        private Player player;

        private UC_GameInventory inventoryPanel;

        internal UC_GameInventory InventoryPanel { get => inventoryPanel; set => inventoryPanel = value; }
        internal Player Player { get => player; set => player = value; }

        public UC_ItemAndQuantity(int idItem, int quantity)
        {
            InitializeComponent();
            this.idItem = idItem;
            this.quantity = quantity;

            this.lbl_Quantity.Parent = this.picBox_Item;
            this.lbl_Quantity.Font = new Font(FunctionsLibs.Font_Alkhemikal,12);

            
        }

        public UC_ItemAndQuantity(int idItem)
        {
            InitializeComponent();
            this.idItem = idItem;
            this.quantity = 1;

            this.lbl_Quantity.Parent = this.picBox_Item;
            this.lbl_Quantity.Font = new Font(FunctionsLibs.Font_Alkhemikal,12);

            
        }


        private void UC_ItemAndQuantity_Load(object sender, EventArgs e)
        {

            this.equipedWeapon = this.inventoryPanel.picBox_EquiWeapon;
            this.equipedArmor = this.inventoryPanel.picBox_EquiArmor;

            if (quantity > 1)
            {
                this.picBox_Item.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"Conso_{idItem}");
                this.lbl_Quantity.Text = quantity.ToString();
            }
            else
            {
                this.picBox_Item.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"Equip_{idItem}");
                this.lbl_Quantity.Text = quantity.ToString();
            }


            if (SQLConnect.isEquiped(this.player.Id, this.idItem))
            {
                this.equipedWeapon.Image = (Image)Properties.Resources.ResourceManager.GetObject($"Equip_{this.idItem}");
            }

        }

        private void onItemClick(object sender, EventArgs e)
        {


            PictureBox picBox = (PictureBox)sender;
            MouseEventArgs me = (MouseEventArgs)e;
            picBox.ContextMenu = new ContextMenu();
            picBox.ContextMenu.MenuItems.Add("Equiper", new EventHandler(btn_Equiper_Click));
            picBox.ContextMenu.MenuItems.Add("Déséquiper", new EventHandler(btn_desequiper_Click));
            picBox.ContextMenu.MenuItems.Add("Jeter", new EventHandler(btn_Jeter_Click));
            picBox.ContextMenu.MenuItems.Add("Utiliser", new EventHandler(btn_Utiliser_Click));
            picBox.ContextMenu.Show(picBox, new Point(me.X,me.Y));

        }

        private void btn_desequiper_Click(object sender, EventArgs e)
        {
            //TODO : Déséquiper l'item
            SQLConnect.unequipWeaponOrArmor(this.player.Id, this.idItem);
            this.inventoryPanel.Player.AdditionalDamage -= SQLConnect.getAdditionnalDamage(this.idItem);
            this.inventoryPanel.Player.MaxHp -= SQLConnect.getAdditionnalHealth(this.idItem);
            equipedWeapon.Image = null;
            equipedArmor.Image = null;
            this.Parent.Refresh();
            this.inventoryPanel.Parent.Refresh();
        }

        private void  btn_Equiper_Click(object sender, EventArgs e)
        {
            //TODO : Equiper l'item
            SQLConnect.equipWeaponOrArmor(this.player.Id, this.idItem);
            equipedWeapon.Image = this.picBox_Item.BackgroundImage;
            equipedArmor.Image = this.picBox_Item.BackgroundImage;
            this.inventoryPanel.Player.AdditionalDamage += SQLConnect.getAdditionnalDamage(this.idItem);
            this.inventoryPanel.Player.MaxHp += SQLConnect.getAdditionnalHealth(this.idItem);
            this.Parent.Refresh();
            this.inventoryPanel.Parent.Refresh();

        }

        private void btn_Jeter_Click(object sender, EventArgs e)
        {
            //TODO : Jeter l'item
        }

        private void btn_Utiliser_Click(object sender, EventArgs e)
        {
            //TODO : Utiliser l'item
        }
    }
}
