using Lynaar_GUI.Classes;
using Lynaar_GUI.Properties;
using Lynaar_GUI.Classes.Miscellaneous;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lynaar_GUI.Login_Parts.UC_
{
    public partial class UC_LoginNewGame : UserControl 
    {
        #region Private variables

        //! Différence de taille entre l'image avant et après le hover
        private int diffPicWidth_OnHover = 5;
        private int diffPicHeight_OnHover = 5;
        private Size sizeBefore;
        private Point locationBefore;
        private Point locationAfter;
        private Size sizeAfter;

        //! Images de fond des boutons
        private Bitmap fondClasse;
        private Bitmap fondClasse_Active;
        private Bitmap startGame;
        private Bitmap StartGame2;

        //! Police de caractère
        private Font font15;
        private Font font20;
        
        //! Son de clic
        SoundPlayer player;

        //! Référence au formulaire parent (LoginForm)
        private Lynaar_GUI.LoginForm parentForm;

        #endregion

        #region Initialisation component & GameForm
        public UC_LoginNewGame(Lynaar_GUI.LoginForm loginForm)
        {            
            InitializeComponent();            

            //! Initialisation des animations de boutons (taille / position)
            this.sizeAfter = new Size(this.picBox_NewGame.Width - this.diffPicWidth_OnHover, this.picBox_NewGame.Height - this.diffPicHeight_OnHover);
            this.locationAfter = new Point(this.picBox_NewGame.Location.X + this.diffPicWidth_OnHover / 2, this.picBox_NewGame.Location.Y + this.diffPicHeight_OnHover / 2);
            this.sizeBefore = new Size(this.picBox_NewGame.Width + this.diffPicWidth_OnHover, this.picBox_NewGame.Height + this.diffPicHeight_OnHover);
            this.locationBefore = new Point(this.picBox_NewGame.Location.X - this.diffPicWidth_OnHover / 2, this.picBox_NewGame.Location.Y - this.diffPicHeight_OnHover / 2);

            //! Initialisation des images de fond des boutons
            this.fondClasse = Properties.Resources.FondClass_Ico;
            this.fondClasse_Active = Properties.Resources.FondClasse_Active_Ico;
            this.startGame = Properties.Resources.StartGame_Parcho_Gris_A;
            this.StartGame2 = Properties.Resources.StartGame2_Parcho_Gris_A;

            //! Initialisation du son de clic
            Stream stream = Resources.SOUND_mainMenuButtonClick;
            this.player = new SoundPlayer(stream);

            //! Initialisation de la police de caractère
            this.font15 = new Font(FunctionsLibs.getFont(), 15);
            this.font20 = new Font(FunctionsLibs.getFont(), 20);

            //! Initialisation du formulaire parent
            this.parentForm = loginForm;

        }

        #endregion


        
    
        private void UC_LoginNewGame_Load(object sender, EventArgs e)
        {
            //! Set the font of the labels
            this.lblWho.Font = this.font15;
            this.lblClassName.Font = this.font15;
            this.lblWhat.Font = this.font20;
            this.lblName.Font = this.font15;
        }

        #region Buttons menu
        private void picBox_NewGame_Click(object sender, EventArgs e)
        {
            //! check if the player has entered a name and a class
            if (txtBoxPseudo.Text != "")
            {
                if (rdbClasseHunter.Checked || rdbClasseMage.Checked || rdbClasseRogue.Checked || rdbClasseWarrior.Checked) 
                { 
                    //! Close the current form and open the game form
                    Thread GameForm_THREAD = new Thread(new ThreadStart(openGameForm));
                    GameForm_THREAD.Start();    
                    this.parentForm.playMusic(); //! Arret de la musique du LoginForm
                    this.ParentForm.Dispose();  //! Fermeture du LoginForm et libération des ressources

                    
                }
                else
                {
                    this.lblError.Font = this.font15;
                    lblError.ForeColor = Color.Red;
                    lblError.TextAlign = ContentAlignment.TopCenter;
                    lblError.Text = "Please select a class";
                }
            }
            else
            {
                this.lblError.Font = this.font15;

                lblError.ForeColor = Color.Red;
                lblError.TextAlign = ContentAlignment.TopCenter;
                lblError.Text = "Please select a name and a class";
            }
        }

        #endregion

        #region Buttons Class

        private void UpdateClassSelection(object sender, string className, Color textColor)
        {
            //! Initialisation des labels
            this.lblClassName.Text = className;
            this.lblClassName.ForeColor = textColor;
            this. lblClassName.TextAlign = ContentAlignment.TopCenter;

            //! Récupération du bouton sélectionné
            RadioButton radio = (RadioButton)sender;

            //! Changement de l'image de fond du bouton sélectionné
            if (radio.Checked)
            {
                radio.BackgroundImage = this.fondClasse_Active;
            }
            else
            {
                radio.BackgroundImage = this.fondClasse;
            }
        }

        #region CheckedChange Events
        private void rdbClasseHunter_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(sender, "Hunter", Color.Green);
        }

        private void rdbClasseWarrior_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(sender, "Warrior", Color.Red); 
        }

        private void rdbClasseRogue_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(sender, "Rogue", Color.Violet); 
        }
        private void rdbClasseMage_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(sender, "Mage", Color.LightBlue);
        }


        #endregion

        #region Hover effects
        private void hoverNewGameButton(object sender, EventArgs e)
        {
            //! Récupération du bouton sélectionné
            PictureBox pic = (PictureBox)sender;

            //! Changement de l'image de fond du bouton sélectionné
            pic.BackgroundImage = this.StartGame2;
            pic.Size = this.sizeAfter;
            pic.Location = this.locationAfter; 

            playClickSound();
            changeCursor();
        }

        private void exitHoverNewGameButton(object sender, EventArgs e)
        {
            //! Récupération du bouton sélectionné
            PictureBox pic = (PictureBox)sender;

            //! Changement de l'image de fond du bouton sélectionné
            pic.BackgroundImage = this.startGame;
            pic.Size = this.sizeBefore;
            pic.Location = this.locationBefore;
            resetCursor();
        }
        #endregion

        #endregion

        #region Functions

        //! Ajout de la fonction permettant l'ouverture du formulaire de jeu
        private void openGameForm()
        {
            Application.Run(new GameForm());
        }

        //!Ajout de la fonction permettant le son lors du survol du bouton 
        private void playClickSound()
        {
            player.Play();
        }

        #region Cursor
        //!Ajout des fonctions permettant le changement du curseur
        private void changeCursor()
        {
            this.Cursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalHelp.ani"));
        }

        private void resetCursor()
        {
            this.Cursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalSelect.ani"));
        }
        #endregion

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            this.player.Dispose();
            FunctionsLibs.add_UControls(new UC_LoginMainMenu(this.parentForm), this.Parent);
            this.Dispose();
        }

        
    }
}
