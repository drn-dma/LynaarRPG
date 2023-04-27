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
            //MessageBox.Show(SQLConnect.ExecuteSql("SELECT * FROM HI",2).ToString());

            pic_ClasseIcon.BackgroundImage = Properties.Resources.Warrior_Ico;
            
        }

        private void add_UControls(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnl_Main.Controls.Clear();
            pnl_Main.Controls.Add(uc);
            uc.BringToFront();
        }
        
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            foreach(var pnl in table_MenuButton.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.FromArgb(51, 51, 76);
            }

            PictureBox btn = (PictureBox)sender;
            switch(btn.Name)
            {
                case "picBox_Inventory":
                    add_UControls(new UC_Inventory());
                    break;
            }

            
        }
    }
}
