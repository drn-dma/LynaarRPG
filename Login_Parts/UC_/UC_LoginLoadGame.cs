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
        private Size backButtonSize_Before;
        private Point backButtonLocation_Before;
        private Point backButtonLocation_After;
        private Size backButtonSize_After;

        private Lynaar_GUI.LoginForm parentForm; //! Référence au formulaire parent (LoginForm)

        private Bitmap Back2_Parcho;
        private Bitmap Back_Parcho;

        //! Curseurs
        private Cursor originalCursor;
        private Cursor hoverCursor;

        private Stream stream;
        private SoundPlayer player;

        #endregion

        public UC_LoginLoadGame(Lynaar_GUI.LoginForm loginForm)
        {
            InitializeComponent();

            this.stream = Resources.SOUND_mainMenuButtonClick;
            this.player = new SoundPlayer(stream);


            this.Back2_Parcho = Properties.Resources.Back2_Parcho_Gris_A;
            this.Back_Parcho = Properties.Resources.Back_Parcho_Gris_A;

            this.backButtonSize_After = new Size(picBoxBackBtn.Width - this.diffPicWidth_OnHover,picBoxBackBtn.Height - this.diffPicHeight_OnHover);
            this.backButtonLocation_After = new Point(picBoxBackBtn.Location.X + this.diffPicWidth_OnHover / 2, picBoxBackBtn.Location.Y + this.diffPicHeight_OnHover / 2);
            this.backButtonSize_Before = new Size(picBoxBackBtn.Width + this.diffPicWidth_OnHover, picBoxBackBtn.Height + this.diffPicHeight_OnHover);
            this.backButtonLocation_Before = new Point(picBoxBackBtn.Location.X - this.diffPicWidth_OnHover / 2, picBoxBackBtn.Location.Y - this.diffPicHeight_OnHover / 2);

            //! Initialisation des curseurs
            this.hoverCursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalHelp.ani"));
            this.originalCursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalSelect.ani"));

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

            pic.BackgroundImage = this.Back2_Parcho;
            pic.Size = this.backButtonSize_After;
            pic.Location = this.backButtonLocation_After;
            changeCursor();
            playClickSound();
        }

        //! Fonction modifiant le style des boutons à la sortie de la souris
        private void exitHoverNewBtn(object sender, EventArgs e)
        {
            //! Récupération du bouton qui a déclenché l'évènement
            PictureBox pic = (PictureBox)sender;

            //! Modification de l'image de fond du bouton

            pic.BackgroundImage = this.Back_Parcho;
            pic.Size = this.backButtonSize_Before;
            pic.Location = this.backButtonLocation_Before;
            resetCursor();
        }

        #endregion

        //! Fonction de modoification du curseur
        #region Cursor
        private void changeCursor()
        {
            this.Cursor = this.hoverCursor;
        }

        private void resetCursor()
        {
            this.Cursor = this.originalCursor;
        }

        #endregion

        private void playClickSound()
        {
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
