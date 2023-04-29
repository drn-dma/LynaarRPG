using Lynaar_GUI.Classes;
using Lynaar_GUI.Classes.Miscellaneous;
using Lynaar_GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Login_Parts.UC_
{
    public partial class UC_LoginLoadGame : UserControl
    {
        private int diffPicWidth_OnHover = 5;
        private int diffPicHeight_OnHover = 5;

        public UC_LoginLoadGame()
        {
            InitializeComponent();
        }

        private void UC_LoginLoadGame_Load(object sender, EventArgs e)
        {

        }

        private void hoverNewBtn(object sender, EventArgs e)
        {


            PictureBox pic = (PictureBox)sender;
            pic.BackgroundImage = Properties.Resources.Back2_Parcho_Gris_A;
            pic.Size = new Size(pic.Width - this.diffPicWidth_OnHover, pic.Height - this.diffPicHeight_OnHover);
            pic.Location = new Point(pic.Location.X + this.diffPicWidth_OnHover / 2, pic.Location.Y + this.diffPicHeight_OnHover / 2);
            changeCursor();
            playClickSound();
        }

        //! Fonction modifiant le style des boutons à la sortie de la souris
        private void exitHoverNewBtn(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackgroundImage = Properties.Resources.Back_Parcho_Gris_A;
            pic.Size = new Size(pic.Width + this.diffPicWidth_OnHover, pic.Height + this.diffPicHeight_OnHover);
            pic.Location = new Point(pic.Location.X - this.diffPicWidth_OnHover / 2, pic.Location.Y - this.diffPicHeight_OnHover / 2);
            resetCursor();
        }


        private void changeCursor()
        {
            this.Cursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalHelp.ani"));
        }

        private void resetCursor()
        {
            this.Cursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalSelect.ani"));
        }

        private void playClickSound()
        {
            Stream stream = Resources.SOUND_mainMenuButtonClick;
            SoundPlayer player = new SoundPlayer(stream);
            player.Play();
        }

        private void picBoxBackBtn_Click(object sender, EventArgs e)
        {
            FunctionsLibs.add_UControls(new UC_LoginMainMenu(), this.Parent);
        }
    }
}
