using Lynaar_GUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Login_Parts.UC_
{
    public partial class UC_LoginMainMenu : UserControl
    {

        private int diffPicWidth_OnHover = 5;
        private int diffPicHeight_OnHover = 5;


        public UC_LoginMainMenu()
        {
            InitializeComponent();
        }

        private void UC_LoginMainMenu_Load(object sender, EventArgs e)
        {
        }

        #region Hover Effects

        #region NewGame Button

        //! Fonction modifiant le style des boutons au survol de la souris
        private void hoverNewBtn(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackgroundImage = Properties.Resources.NewGame2_Parcho_Gris_A;
            pic.Size = new Size(pic.Width - this.diffPicWidth_OnHover, pic.Height - this.diffPicHeight_OnHover);
            pic.Location = new Point(pic.Location.X + this.diffPicWidth_OnHover / 2, pic.Location.Y + this.diffPicHeight_OnHover / 2);
        }

        //! Fonction modifiant le style des boutons à la sortie de la souris
        private void exitHoverNewBtn(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackgroundImage = Properties.Resources.NewGame_Parcho_Gris_A;
            pic.Size = new Size(pic.Width + this.diffPicWidth_OnHover, pic.Height + this.diffPicHeight_OnHover);
            pic.Location = new Point(pic.Location.X - this.diffPicWidth_OnHover / 2, pic.Location.Y - this.diffPicHeight_OnHover / 2);
        }

        #endregion

        #region LoadGame Button

        //! Fonction modifiant le style des boutons au survol de la souris
        private void hoverLoadBtn(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackgroundImage = Properties.Resources.LoadGame2_Parcho_Gris_A;
            pic.Size = new Size(pic.Width - this.diffPicWidth_OnHover, pic.Height - this.diffPicHeight_OnHover);
            pic.Location = new Point(pic.Location.X + this.diffPicWidth_OnHover / 2, pic.Location.Y + this.diffPicHeight_OnHover / 2);
        }

        //! Fonction modifiant le style des boutons à la sortie de la souris
        private void exitHoverLoadBtn(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackgroundImage = Properties.Resources.LoadGame_Parcho_Gris_A;
            pic.Size = new Size(pic.Width + this.diffPicWidth_OnHover, pic.Height + this.diffPicHeight_OnHover);
            pic.Location = new Point(pic.Location.X - this.diffPicWidth_OnHover / 2, pic.Location.Y - this.diffPicHeight_OnHover / 2);
        }

        #endregion

        #region Exit Button

        //! Fonction modifiant le style des boutons au survol de la souris
        private void hoverExitBtn(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackgroundImage = Properties.Resources.ExitGame2_Parcho_Gris_A;
            pic.Size = new Size(pic.Width - this.diffPicWidth_OnHover, pic.Height - this.diffPicHeight_OnHover);
            pic.Location = new Point(pic.Location.X + this.diffPicWidth_OnHover / 2, pic.Location.Y + this.diffPicHeight_OnHover / 2);
        }

        //! Fonction modifiant le style des boutons à la sortie de la souris
        private void exitHoverExitBtn(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackgroundImage = Properties.Resources.ExitGame_Parcho_Gris_A;
            pic.Size = new Size(pic.Width + this.diffPicWidth_OnHover, pic.Height + this.diffPicHeight_OnHover);
            pic.Location = new Point(pic.Location.X - this.diffPicWidth_OnHover / 2, pic.Location.Y - this.diffPicHeight_OnHover / 2);
        }

        #endregion

        #endregion

        private void picBox_ExitGame_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void picBox_NewGame_Click(object sender, EventArgs e)
        {
            FunctionsLibs.add_UControls(new UC_LoginNewGame(), this.Parent);
        }



        
    }
}
