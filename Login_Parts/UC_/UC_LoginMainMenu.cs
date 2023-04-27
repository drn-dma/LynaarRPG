using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Login_Parts.UC_
{
    public partial class UC_LoginMainMenu : UserControl
    {
        public UC_LoginMainMenu()
        {
            InitializeComponent();
        }

        private void UC_LoginMainMenu_Load(object sender, EventArgs e)
        {

        }

        //! Fonction modifiant le style des boutons au survol de la souris
        private void hoverBtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatStyle = FlatStyle.Flat;                    //! FlatStyle.Flat permet de supprimer le style par défaut du bouton
            btn.ForeColor = Color.Black;
            btn.FlatAppearance.MouseOverBackColor = Color.White;
        }

        //! Fonction modifiant le style des boutons à la sortie de la souris
        private void exitHoverBtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatStyle = FlatStyle.Flat;                     //! FlatStyle.Flat permet de supprimer le style par défaut du bouton
            btn.ForeColor = Color.White;
            btn.FlatAppearance.MouseOverBackColor = Color.Black;
        }
    }
}
