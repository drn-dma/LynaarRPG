using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI
{
    public partial class UC_GameInventory : UserControl
    {
        public UC_GameInventory()
        {
            InitializeComponent();
            
            
        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.Font_Alkhemikal.Length;
            byte[] fontdata = Properties.Resources.Font_Alkhemikal;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);


            //Set label font
            lbl_Inventaire.Font = new Font(pfc.Families[0],40, FontStyle.Regular);
        }

        private void lbl_Inventaire_Click(object sender, EventArgs e)
        {

        }
    }
}
