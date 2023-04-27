using Lynaar_GUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();

            //!Font
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.Font_Alkhemikal.Length;
            byte[] fontdata = Properties.Resources.Font_Alkhemikal;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var enemy = SQLConnect.readDataFromSQL("SELECT * FROM Enemy");
            string result = "";
            foreach(var row in enemy)
            {
                result += row["name"].ToString() + "\n";
            }
            MessageBox.Show(result);

            pic_ClasseIcon.BackgroundImage = Properties.Resources.Warrior_Ico;
            
        }

        
        
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            foreach(var pnl in table_MenuButton.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Beige;
            }

            PictureBox btn = (PictureBox)sender;
            switch(btn.Name)
            {
                case "picBox_Inventory":
                    FunctionsLibs.add_UControls(new UC_GameInventory(),pnl_Main);
                    break;
            }

            
        }
    }
}
