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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pic_ClasseIcon.BackgroundImage = Properties.Resources.Warrior_Ico;
            
        }

        
        //! Fonction affichage des UC (UserControl) dans le panel principal 'pnl_Main' en fonction du bouton cliqué
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //! Récupération de l'objet cliqué (sender) et conversion en PictureBox
            PictureBox btn = (PictureBox)sender;

            //! Switch en fonction du nom du bouton cliqué
            switch(btn.Name)
            {
                case "picBox_Inventory":
                    FunctionsLibs.add_UControls(new UC_GameInventory(),pnl_Main);
                    break;
            }

            
        }
    }
}
