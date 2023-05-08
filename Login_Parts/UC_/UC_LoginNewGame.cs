using Lynaar_GUI.Classes;
using Lynaar_GUI.Properties;
using Lynaar_GUI.Classes.Miscellaneous;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;


namespace Lynaar_GUI.Login_Parts.UC_
{
    public partial class UC_LoginNewGame : UserControl 
    {
        #region Private variables

        //! Différence de taille entre l'image avant et après le hover
        private int diffPicWidth_OnHover = 5;
        private int diffPicHeight_OnHover = 5;
        private Size sizeBefore;
        private Size sizeAfter;
        private Point locationBefore;
        private Point locationAfter;
        private Point LocationMenuBefore;
        private Point LocationMenuAfter;
        private Size SizeMenuBefore;
        private Size SizeMenuAfter;
        

        //! Images de fond des boutons
        private Bitmap fondClasse;
        private Bitmap fondClasse_Active;
        private Bitmap startGame;
        private Bitmap StartGame2;
        private Bitmap Int;
        private Bitmap Endure;
        private Bitmap ExitMenu;
        private Bitmap ExitMenu2;

        //! Police de caractère
        private Font font10;
        private Font font12;
        private Font font15;
        private Font font20;

        //! Son de clic

        //! Curseurs
        private Cursor originalCursor;
        private Cursor hoverCursor;

        //! Référence au formulaire parent (LoginForm)
        private Lynaar_GUI.LoginForm parentForm;
        private List<Dictionary<string, object>> allPlayers;

        #endregion

        #region Initialisation component & GameForm
        public UC_LoginNewGame(Lynaar_GUI.LoginForm loginForm, List<Dictionary<string, object>> players)
        {            
            InitializeComponent();  
            
            //! Initialisation du formulaire parent
            this.parentForm = loginForm;
            
            this.allPlayers = players;

        }

        #endregion

        #region Load events
        private void UC_LoginNewGame_Load(object sender, EventArgs e)
        {
            //! Initialisation des animations de boutons (taille / position)
            this.sizeAfter = new Size(this.picBox_NewGame.Width - this.diffPicWidth_OnHover, this.picBox_NewGame.Height - this.diffPicHeight_OnHover);
            this.locationAfter = new Point(this.picBox_NewGame.Location.X + this.diffPicWidth_OnHover / 2, this.picBox_NewGame.Location.Y + this.diffPicHeight_OnHover / 2);
            this.sizeBefore = new Size(this.picBox_NewGame.Width + this.diffPicWidth_OnHover, this.picBox_NewGame.Height + this.diffPicHeight_OnHover);
            this.locationBefore = new Point(this.picBox_NewGame.Location.X - this.diffPicWidth_OnHover / 2, this.picBox_NewGame.Location.Y - this.diffPicHeight_OnHover / 2);
            this.LocationMenuAfter= new Point(this.pbBackMenu.Location.X + this.diffPicWidth_OnHover / 2, this.pbBackMenu.Location.Y + this.diffPicHeight_OnHover / 2);
            this.LocationMenuBefore = new Point(this.pbBackMenu.Location.X - this.diffPicWidth_OnHover / 2, this.pbBackMenu.Location.Y - this.diffPicHeight_OnHover / 2);
            this.SizeMenuAfter = new Size(this.pbBackMenu.Width - this.diffPicWidth_OnHover, this.pbBackMenu.Height - this.diffPicHeight_OnHover);
            this.SizeMenuBefore = new Size(this.pbBackMenu.Width + this.diffPicWidth_OnHover, this.pbBackMenu.Height + this.diffPicHeight_OnHover);

            //! Initialisation des images de fond des boutons
            this.fondClasse = Properties.Resources.FondClass_Ico;
            this.fondClasse_Active = Properties.Resources.FondClasse_Active_Ico;
            this.startGame = Properties.Resources.StartGame_Parcho_Gris_A;
            this.StartGame2 = Properties.Resources.StartGame2_Parcho_Gris_A;
            this.Int = Properties.Resources.Int32_Ico;
            this.Endure = Properties.Resources.Endure32_Ico;
            this.ExitMenu = Properties.Resources.Menu_Icon_x64;
            this.ExitMenu2 = Properties.Resources.Menu_Icon_Active_x64;



            //! Initialisation de la police de caractère
            this.font10 = new Font(FunctionsLibs.Font_Alkhemikal, 10);
            this.font12 = new Font(FunctionsLibs.Font_Alkhemikal, 12);
            this.font15 = new Font(FunctionsLibs.Font_Alkhemikal, 15);
            this.font20 = new Font(FunctionsLibs.Font_Alkhemikal, 20);

            /*this.font15 = new Font(@"Fonts\Alkhemikal.ttf", 15);
            this.font20 = new Font(@"Fonts\Alkhemikal.ttf", 20);*/


            //! Initialisation des curseurs
            this.hoverCursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalHelp.ani"));
            this.originalCursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalSelect.ani"));


            //! Set the font of the labels
            this.lblWho.Font = this.font15;
            this.lblClass.Font = this.font20;
            this.lblWhat.Font = this.font20;
            this.lblName.Font = this.font15;
            this.lblDescibClass.Font = this.font12;
            this.lblAtk.Font = this.font12;
            this.lblHp.Font = this.font12;
            this.lblIntAndEndure.Font = this.font12;

            //! Set the Warrior class as default
            this.rdbClasseWarrior.Checked = true;
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
/*                    Thread GameForm_THREAD = new Thread(new ThreadStart(openGameForm));
                    GameForm_THREAD.Start();*/    
                    this.parentForm.PlayMusic(); //! Arret de la musique du LoginForm
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
            //! Récupération du bouton sélectionné
            RadioButton radio = (RadioButton)sender;

            //! Changement de l'image de fond du bouton sélectionné
            if (radio.Checked)
            {
                if (!lblClass.Visible && !lblDescibClass.Visible)
                {
                    lblClass.Visible = true;
                    lblDescibClass.Visible = true;
                    lblHp.Visible = true;
                    lblAtk.Visible = true;
                    lblIntAndEndure.Visible = true;
                    pbHp.Visible = true;
                    pbAtk.Visible = true;
                    pbIntAndEndure.Visible = true;
                }

                //!ajout de l'image Int et Endure en fonction de la classe sélectionnée
                if (className == "Mage")
                {
                    pbIntAndEndure.BackgroundImage = Int;
                }
                else
                {
                    pbIntAndEndure.BackgroundImage = Endure;
                }

                radio.BackgroundImage = this.fondClasse_Active;
                
            }
            else
            {
                radio.BackgroundImage = this.fondClasse;
            }

            //! changement du label lblClass en fonction de la classe sélectionnée
            this.lblClass.Text = className;
            this.lblClass.ForeColor = textColor;

        }

        #region CheckedChange Events
        private void rdbClasseHunter_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(sender, "Hunter", Color.Green);
            lblDescibClass.Text= "The Hunter is a master of the wilds, able to tame beasts and command them to do his bidding. He is a ranged fighter, able to deal with threats from afar, and uses traps to hinder his enemies.";
            lblAtk.Text = "10";
            lblHp.Text = "100";
            lblIntAndEndure.Text = "25";
        }

        private void rdbClasseWarrior_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(sender, "Warrior", Color.Red);
            lblDescibClass.Text = "The Warrior is a stoic adventurer who uses brute force and skillful combat to prevail against enemies. His legendary valor and strength are complemented by his steel nerves.";
            lblAtk.Text = "5";
            lblHp.Text = "150";
            lblIntAndEndure.Text = "5";

        }

        private void rdbClasseRogue_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(sender, "Rogue", Color.Purple);
            lblDescibClass.Text = "The Rogue is a versatile class, able to dish out considerable damage to their enemies with vicious flurry of attacks, but also able to sneak around and pick locks, allowing them to be effective scouts and spies.";
            lblAtk.Text = "20";
            lblHp.Text = "75";
            lblIntAndEndure.Text = "20";
        }
        private void rdbClasseMage_CheckedChanged(object sender, EventArgs e)
        {
            UpdateClassSelection(sender, "Mage", Color.Blue);
            lblDescibClass.Text = "The Mage is a spellcaster, who uses his powers to curse enemies, deal large amounts of damage and teleport around enemies.";
            lblAtk.Text = "15";
            lblHp.Text = "90";
            lblIntAndEndure.Text = "20";
            
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

        //!Animation du bouton de retour au menu
        private void hoverBackMenuButton(object sender, EventArgs e)
        {
            //! Récupération du bouton sélectionné
            PictureBox pic = (PictureBox)sender;

            //! Changement de l'image de fond du bouton sélectionné
            pic.BackgroundImage = this.ExitMenu2;
            pic.Size = this.SizeMenuAfter;
            pic.Location = this.LocationMenuAfter;
            //changeCursor();
        }

        private void exitHoverBackMenuButton(object sender, EventArgs e)
        {
            //! Récupération du bouton sélectionné
            PictureBox pic = (PictureBox)sender;
            //! Changement de l'image de fond du bouton sélectionné
            pic.BackgroundImage = this.ExitMenu;
            pic.Size = this.SizeMenuBefore;
            pic.Location = this.LocationMenuBefore;
            //resetCursor();
        }   
        #endregion

        #endregion

        #region Functions

        //! Ajout de la fonction permettant l'ouverture du formulaire de jeu
        /*private void openGameForm()
        {
            

            this.Hide();
 
            gameForm.Show();

            //TODO Trouver une alternative a Application.run
            *//*Application.Run(new GameForm());*//*
        }*/

        //!Ajout de la fonction permettant le son lors du survol du bouton 

        #region Cursor
        //!Ajout des fonctions permettant le changement du curseur
        private void changeCursor()
        {
            this.Cursor = this.hoverCursor;
        }

        private void resetCursor()
        {
            this.Cursor = this.originalCursor;
        }
        #endregion

        #endregion

        #region BackMenu Button
        private void pbBackMenu_Click(object sender, EventArgs e)
        {
            FunctionsLibs.add_UControls(new UC_LoginMainMenu(this.parentForm, allPlayers), this.Parent);
            this.Dispose();
        }
        #endregion


        
    }
}
