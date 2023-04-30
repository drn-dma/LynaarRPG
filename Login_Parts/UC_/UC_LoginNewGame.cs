using Lynaar_GUI.Classes;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Login_Parts.UC_
{
    public partial class UC_LoginNewGame : UserControl
    {
        #region Private variables
        private int diffPicWidth_OnHover = 5;
        private int diffPicHeight_OnHover = 5;
        private Size originalSize;
        private Point originalLocation;
        #endregion

        #region Initialisation component & GameForm
        public UC_LoginNewGame()
        {
            GC.Collect();
            InitializeComponent();
        }

        private void openGameForm()
        {
            Application.Run(new GameForm());
        }
        #endregion

        #region Actions on page load
        private void UC_LoginNewGame_Load(object sender, EventArgs e)
        {
            //! Set the font of the labels
            FunctionsLibs.setFont(lblWho, 20);
            FunctionsLibs.setFont(lblClassName, 15);
            FunctionsLibs.setFont(lblWhat, 20);
            FunctionsLibs.setFont(lblName, 15);
        }
        #endregion

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

                    ((Form)this.TopLevelControl).Close();
                }
                else
                {
                    FunctionsLibs.setFont(lblError, 15);
                    lblError.ForeColor = Color.Red;
                    lblError.TextAlign = ContentAlignment.TopCenter;
                    lblError.Text = "Please select a class";
                }
            }
            else
            {
                FunctionsLibs.setFont(lblError, 15);
                lblError.ForeColor = Color.Red;
                lblError.TextAlign = ContentAlignment.TopCenter;
                lblError.Text = "Please select a name and a class";
            }
        }

        #endregion

        #region Buttons Class

        private void UpdateClassSelection(RadioButton selected, string className, Color textColor)
        {
            lblClassName.Text = className;
            lblClassName.ForeColor = textColor;
            lblClassName.TextAlign = ContentAlignment.TopCenter;

            RadioButton[] allRadioButtons = new RadioButton[] { rdbClasseMage, rdbClasseHunter, rdbClasseWarrior, rdbClasseRogue };

            // Désabonner temporairement les événements CheckedChanged
            rdbClasseMage.CheckedChanged -= rdbClasseMage_CheckedChanged;
            rdbClasseHunter.CheckedChanged -= rdbClasseHunter_CheckedChanged;
            rdbClasseWarrior.CheckedChanged -= rdbClasseWarrior_CheckedChanged;
            rdbClasseRogue.CheckedChanged -= rdbClasseRogue_CheckedChanged;

            foreach (RadioButton radioButton in allRadioButtons)
            {
                radioButton.BackgroundImage = (radioButton == selected) ? Resources.FondClasse_Active_Ico : Resources.FondClass_Ico;
                radioButton.Checked = (radioButton == selected);
            }

            // Réabonner les événements CheckedChanged
            rdbClasseMage.CheckedChanged += rdbClasseMage_CheckedChanged;
            rdbClasseHunter.CheckedChanged += rdbClasseHunter_CheckedChanged;
            rdbClasseWarrior.CheckedChanged += rdbClasseWarrior_CheckedChanged;
            rdbClasseRogue.CheckedChanged += rdbClasseRogue_CheckedChanged;
            //delete the list of radiobuttons
        }
        private void rdbClasseHunter_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(rdbClasseHunter, "Hunter", Color.Green);
        }

        private void rdbClasseWarrior_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(rdbClasseWarrior, "Warrior", Color.Red);
        }

        private void rdbClasseRogue_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(rdbClasseRogue, "Rogue", Color.Violet);
        }
        private void rdbClasseMage_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(rdbClasseMage, "Mage", Color.LightBlue);
        }


        #endregion

        #region Hover effects
        private void hoverNewGameButton(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackgroundImage = Resources.NewGame2_Parcho_Gris_A;
            originalSize = pic.Size;
            originalLocation = pic.Location;
            pic.Size = new Size(originalSize.Width - this.diffPicWidth_OnHover, originalSize.Height - this.diffPicHeight_OnHover / 2);
            pic.Location = new Point(originalLocation.X + this.diffPicWidth_OnHover / 2, originalLocation.Y + this.diffPicHeight_OnHover / 2);
            playClickSound();
            //changeCursor();
        }

        private void exitHoverNewGameButton(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackgroundImage = Resources.NewGame_Parcho_Gris_A;
            pic.Size = originalSize;
            pic.Location = originalLocation;
            //resetCursor();
        }
        #endregion

        #region Functions

        //!Ajout de la fonction permettant le son lors du survol du bouton 
        private void playClickSound()
        {
            Stream stream = Resources.SOUND_mainMenuButtonClick;
            SoundPlayer player = new SoundPlayer(stream);
            player.Play();
        }

        //!Ajout des fonctions permettant le changement du curseur
        /*private void changeCursor()
        {
            this.Cursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalHelp.ani"));
        }

        private void resetCursor()
        {
            this.Cursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalSelect.ani"));
        }*/
        #endregion
    }
}
