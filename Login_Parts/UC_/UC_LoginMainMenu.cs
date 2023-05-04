using Lynaar_GUI.Classes;
using Lynaar_GUI.Classes.Miscellaneous;
using Lynaar_GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Login_Parts.UC_
{
    public partial class UC_LoginMainMenu : UserControl
    {
        #region Private variables

        //! Différence de taille entre l'image du bouton et l'image du bouton lorsqu'il est survolé
        private int diffPicWidth_OnHover = 5;
        private int diffPicHeight_OnHover = 5;
        private Size sizeBefore;
        private Point locationBeforeNew;
        private Point locationAfterNew;
        private Point locationBeforeLoad;
        private Point locationAfterLoad;
        private Point locationBeforeExit;
        private Point locationAfterExit;
        private Size sizeAfter;

        //! Son des boutons
        private Stream stream;
        private SoundPlayer player;

        //! Images des boutons
        private Bitmap NewGame;
        private Bitmap LoadGame;
        private Bitmap ExitGame;
        private Bitmap NewGame2;
        private Bitmap LoadGame2;
        private Bitmap ExitGame2;

        //! Curseurs
        private Cursor originalCursor;
        private Cursor hoverCursor;

        List<Dictionary<string, object>> allPlayers;

        private Lynaar_GUI.LoginForm parentForm; //! Référence au formulaire parent

        #endregion


        public UC_LoginMainMenu(Lynaar_GUI.LoginForm parentForm, List<Dictionary<string, object>> players)
        {
            InitializeComponent();

            //! Initialisation des variables de position et de taille des boutons
            this.sizeAfter = new Size(this.picBox_NewGame.Width - this.diffPicWidth_OnHover, this.picBox_NewGame.Height - this.diffPicHeight_OnHover);
            this.sizeBefore = new Size(this.picBox_NewGame.Width + this.diffPicWidth_OnHover, this.picBox_NewGame.Height + this.diffPicHeight_OnHover);
            
            //! Initialisation du son
            this.stream = Resources.SOUND_mainMenuButtonClick;
            this.player = new SoundPlayer(this.stream);

            //! Initialisation des images des boutons
            this.NewGame = Properties.Resources.NewGame_Parcho_Gris_A;
            this.LoadGame = Properties.Resources.LoadGame_Parcho_Gris_A;
            this.ExitGame = Properties.Resources.ExitGame_Parcho_Gris_A;
            this.NewGame2 = Properties.Resources.NewGame2_Parcho_Gris_A;
            this.LoadGame2 = Properties.Resources.LoadGame2_Parcho_Gris_A;
            this.ExitGame2 = Properties.Resources.ExitGame2_Parcho_Gris_A;

            //! Initialisation des curseurs
            this.hoverCursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalHelp.ani"));
            this.originalCursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalSelect.ani"));

            //! Initialisation du parent
            this.parentForm = parentForm;

            allPlayers = players;
        }

        private void UC_LoginMainMenu_Load(object sender, EventArgs e)
        {

        }

        #region Hover Effects

        #region NewGame Button

        //! Fonction modifiant le style des boutons au survol de la souris
        private void hoverNewBtn(object sender, EventArgs e)
        {
            //! Récupération du bouton qui a appelé la fonction
            PictureBox pic = (PictureBox)sender;
            
            //! Mise à jour de la position de l'image du bouton lorsqu'il est survolé (si elle n'a pas été initialisée)
            if (this.locationAfterNew.X == 0 && this.locationAfterNew.Y == 0)
            {
                this.locationAfterNew = new Point(this.picBox_NewGame.Location.X + this.diffPicWidth_OnHover / 2, this.picBox_NewGame.Location.Y + this.diffPicHeight_OnHover / 2);
            }

            

            //! Changement de l'image du bouton, de sa taille et de sa position
            pic.BackgroundImage = this.NewGame2;
            pic.Size = this.sizeAfter;
            pic.Location = this.locationAfterNew;


            changeCursor();
            playClickSound();
        }

        //! Fonction modifiant le style des boutons à la sortie de la souris
        private void exitHoverNewBtn(object sender, EventArgs e)
        {
            //! Récupération du bouton qui a appelé la fonction
            PictureBox pic = (PictureBox)sender;

            //! Mise à jour de la position de l'image du bouton lorsqu'il est survolé (si elle n'a pas été initialisée)
            if (this.locationBeforeNew.X == 0 && this.locationBeforeNew.Y == 0)
            {
                this.locationBeforeNew = new Point(this.picBox_NewGame.Location.X - this.diffPicWidth_OnHover / 2, this.picBox_NewGame.Location.Y - this.diffPicHeight_OnHover / 2);
            }

            //! Changement de l'image du bouton, de sa taille et de sa position
            pic.BackgroundImage = this.NewGame;
            pic.Size = this.sizeBefore;
            pic.Location = this.locationAfterNew;

            resetCursor();
        }

        #endregion

        #region LoadGame Button

        //! Fonction modifiant le style des boutons au survol de la souris
        private void hoverLoadBtn(object sender, EventArgs e)
        {
            //! Récupération du bouton qui a appelé la fonction
            PictureBox pic = (PictureBox)sender;

            //! Mise à jour de la position de l'image du bouton lorsqu'il est survolé (si elle n'a pas été initialisée)
            if (this.locationAfterLoad.X == 0 && this.locationAfterLoad.Y == 0)
            {
                this.locationAfterLoad = new Point(this.picBox_LoadGame.Location.X + this.diffPicWidth_OnHover / 2, this.picBox_LoadGame.Location.Y + this.diffPicHeight_OnHover / 2);
            }

            //! Changement de l'image du bouton, de sa taille et de sa position
            pic.BackgroundImage = this.LoadGame2;
            pic.Size = this.sizeAfter;
            pic.Location = this.locationAfterLoad; 

            changeCursor();
            playClickSound();

        }

        //! Fonction modifiant le style des boutons à la sortie de la souris
        private void exitHoverLoadBtn(object sender, EventArgs e)
        {
            //! Récupération du bouton qui a appelé la fonction
            PictureBox pic = (PictureBox)sender;

            //! Mise à jour de la position de l'image du bouton lorsqu'il est survolé (si elle n'a pas été initialisée)
            if (this.locationBeforeLoad.X == 0 && this.locationBeforeLoad.Y == 0)
            {
                this.locationBeforeLoad = new Point(this.picBox_LoadGame.Location.X - this.diffPicWidth_OnHover / 2, this.picBox_LoadGame.Location.Y - this.diffPicHeight_OnHover / 2);
            }

            //! Changement de l'image du bouton, de sa taille et de sa position
            pic.BackgroundImage = this.LoadGame;
            pic.Size = this.sizeBefore;
            pic.Location = this.locationBeforeLoad; 

            resetCursor();

        }

        #endregion

        #region Exit Button

        //! Fonction modifiant le style des boutons au survol de la souris
        private void hoverExitBtn(object sender, EventArgs e)
        {
            //! Récupération du bouton qui a appelé la fonction
            PictureBox pic = (PictureBox)sender;

            //! Mise à jour de la position de l'image du bouton lorsqu'il est survolé (si elle n'a pas été initialisée)
            if (this.locationAfterExit.X == 0 && this.locationAfterExit.Y == 0)
            {
                this.locationAfterExit = new Point(this.picBox_ExitGame.Location.X + this.diffPicWidth_OnHover / 2, this.picBox_ExitGame.Location.Y + this.diffPicHeight_OnHover / 2);
            }

            //! Changement de l'image du bouton, de sa taille et de sa position
            pic.BackgroundImage = this.ExitGame2;
            pic.Size = this.sizeAfter;
            pic.Location = this.locationAfterExit; 

            changeCursor();
            playClickSound();

        }

        //! Fonction modifiant le style des boutons à la sortie de la souris
        private void exitHoverExitBtn(object sender, EventArgs e)
        {
            //! Récupération du bouton qui a appelé la fonction
            PictureBox pic = (PictureBox)sender;

            //! Mise à jour de la position de l'image du bouton lorsqu'il est survolé (si elle n'a pas été initialisée)
            if (this.locationBeforeExit.X == 0 && this.locationBeforeExit.Y == 0)
            {
                this.locationBeforeExit = new Point(this.picBox_ExitGame.Location.X - this.diffPicWidth_OnHover / 2, this.picBox_ExitGame.Location.Y - this.diffPicHeight_OnHover / 2);
            }

            //! Changement de l'image du bouton, de sa taille et de sa position
            pic.BackgroundImage = this.ExitGame;
            pic.Size = this.sizeBefore;
            pic.Location = this.locationBeforeExit; 

            resetCursor();
            
        }


        #endregion

        #endregion

        #region Click Events
        private void picBox_ExitGame_Click(object sender, EventArgs e)
        {
            this.player.Dispose(); //! Libération des ressources utilisées par le player
            this.parentForm.Close();
        }

        private void picBox_NewGame_Click(object sender, EventArgs e)
        {
            FunctionsLibs.add_UControls(new UC_LoginNewGame(this.parentForm, allPlayers), this.Parent);
            
        }

        private void picBox_LoadGame_Click(object sender, EventArgs e)
        {
            FunctionsLibs.add_UControls(new UC_LoginLoadGame(this.parentForm, allPlayers), this.Parent);
        }

        #endregion

        private void playClickSound()
        {  
            this.player.Play();    
        }

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

        
    }
}
