using System;
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


        public UC_ItemAndQuantity(int idItem, int quantity)
        {
            InitializeComponent();
            this.idItem = idItem;
            this.quantity = quantity;
        }

        public UC_ItemAndQuantity(int idItem)
        {
            InitializeComponent();
            this.idItem = idItem;
            this.quantity = 1;

        }


        private void UC_ItemAndQuantity_Load(object sender, EventArgs e)
        {
            this.picBox_Item.Image = (Image)Properties.Resources.ResourceManager.GetObject($"Equip_{idItem}");
            this.lbl_Quantity.Text = quantity.ToString();
        }
    }
}
