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
        private Size savePanel_Before;
        private Size savePanel_After;
        private Point savePanelLocation_Before;
        private Point savePanelLocation_After;
        private Size deleteButton_Before;
        private Size deleteButton_After;
        private Point deleteButtonLocation_Before;
        private Point deleteButtonLocation_After;

        private Lynaar_GUI.LoginForm parentForm; //! Référence au formulaire parent (LoginForm)

        private Bitmap Back2_Parcho;
        private Bitmap Back_Parcho;

        //! Curseurs
        private Cursor originalCursor;
        private Cursor hoverCursor;

        private Stream stream;
        private SoundPlayer player;


        List<Dictionary<string, object>> allPlayers = null;

        #endregion

        public UC_LoginLoadGame(Lynaar_GUI.LoginForm loginForm, List<Dictionary<string, object>> players)
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

            //! Récupération des données de la table "Player" de la base de données
            //! Si contient joueur, alors afficher leur partie

            allPlayers = players;

            

        }


        #region Methods

        private void UC_LoginLoadGame_Load(object sender, EventArgs e)
        {
            if (allPlayers != null)
            {
                int i = 1;

                foreach(var player in allPlayers)
                {
                    FunctionsLibs.add_UControls(new LoadGame.UC_LoadGameWithSave(this.parentForm, allPlayers), Parent.Controls.Find("pnl_Save" + i, true)[0]);
                    Parent.Controls.Find("picBox_Delete" + i, true)[0].Visible = true;
                    i++;
                }

                while(i < 4)
                {
                    FunctionsLibs.add_UControls(new LoadGame.UC_LoadGameWithoutSave(this.parentForm), Parent.Controls.Find("pnl_Save" + i, true)[0]);
                    Parent.Controls.Find("picBox_Delete" + i, true)[0].Visible = false;
                    i++;
                }

            }
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


        private void hoverSaveAndDelete(object sender, EventArgs e)
        {
            //! Récupération du bouton qui a déclenché l'évènement
            PictureBox pic = (PictureBox)sender;
            //! Modification de l'image de fond du bouton
            pic.Size = new Size(pic.Width - 5, pic.Height - 5);
            pic.Location = new Point(pic.Location.X + 5 / 2, pic.Location.Y + 5 / 2);
            changeCursor();
            playClickSound();
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
            FunctionsLibs.add_UControls(new UC_LoginMainMenu(this.parentForm, allPlayers), this.Parent);
        }

        #endregion

        #endregion
    }
}
