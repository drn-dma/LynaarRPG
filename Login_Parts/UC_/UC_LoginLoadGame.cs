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
        #region Attributs

        //! Différence de taille des images au survol de la souris (animation)
        private int diffPicWidth_OnHover = 5;
        private int diffPicHeight_OnHover = 5;

        private Lynaar_GUI.LoginForm parentForm; //! Référence au formulaire parent (LoginForm)

        #endregion

        public UC_LoginLoadGame(Lynaar_GUI.LoginForm loginForm)
        {
            InitializeComponent();

            //! Initialisation de la référence au formulaire parent passé en paramètre
            this.parentForm = loginForm;
        }


        #region Methods

        private void UC_LoginLoadGame_Load(object sender, EventArgs e)
        {

        }

        #region Hover Methods
        private void hoverNewBtn(object sender, EventArgs e)
        {
            //! Récupération du bouton qui a déclenché l'évènement
            PictureBox pic = (PictureBox)sender;

            //! Modification de l'image de fond du bouton

            pic.BackgroundImage = Properties.Resources.Back2_Parcho_Gris_A;
            pic.Size = new Size(pic.Width - this.diffPicWidth_OnHover, pic.Height - this.diffPicHeight_OnHover);
            pic.Location = new Point(pic.Location.X + this.diffPicWidth_OnHover / 2, pic.Location.Y + this.diffPicHeight_OnHover / 2);
            changeCursor();
            playClickSound();
        }

        //! Fonction modifiant le style des boutons à la sortie de la souris
        private void exitHoverNewBtn(object sender, EventArgs e)
        {
            //! Récupération du bouton qui a déclenché l'évènement
            PictureBox pic = (PictureBox)sender;

            //! Modification de l'image de fond du bouton

            pic.BackgroundImage = Properties.Resources.Back_Parcho_Gris_A;
            pic.Size = new Size(pic.Width + this.diffPicWidth_OnHover, pic.Height + this.diffPicHeight_OnHover);
            pic.Location = new Point(pic.Location.X - this.diffPicWidth_OnHover / 2, pic.Location.Y - this.diffPicHeight_OnHover / 2);
            resetCursor();
        }

        #endregion

        //! Fonction de modoification du curseur
        #region Cursor Methods
        private void changeCursor()
        {
            this.Cursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalHelp.ani"));
        }

        private void resetCursor()
        {
            this.Cursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalSelect.ani"));
        }

        #endregion

        private void playClickSound()
        {
            Stream stream = Resources.SOUND_mainMenuButtonClick;
            SoundPlayer player = new SoundPlayer(stream);
            player.Play();
        }

        #region Click Methods

        private void picBoxBackBtn_Click(object sender, EventArgs e)
        {
            //! Retour au menu principal
            FunctionsLibs.add_UControls(new UC_LoginMainMenu(this.parentForm), this.Parent);
        }

        #endregion

        #endregion
    }
}
