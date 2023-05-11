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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Login_Parts.UC_.LoadGame
{
    public partial class UC_LoadGameWithSave : UserControl
    {

        #region Variables

        private Form parentForm; //! Formulaire parent : LoginForm

        private List<Dictionary<string, object>> allPlayer = null; //! Liste de tous les joueurs

        private int playerIndex;
        //! Images
        private Bitmap onHover_Back;
        private Bitmap normal_Back;

        //! Curseurs
        private Cursor originalCursor;
        private Cursor hoverCursor;


        #endregion

        public UC_LoadGameWithSave(Form parent, List<Dictionary<string, object>> players) //todo Enlever le commentaire pour introduire le sql
        {
            InitializeComponent();

            this.parentForm = parent;

            this.allPlayer = players;

            //! Initialisation des images
            this.onHover_Back = Resources.SavedGame_Hover_background;
            this.normal_Back = this.BackgroundImage as Bitmap;

            //! Initialisation des curseurs
            this.hoverCursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalHelp.ani"));
            this.originalCursor = CustomCursor.Create(Path.Combine(Application.StartupPath, "Cursors\\MedievalSelect.ani"));

        }

        private void UC_LoadGameWithSave_Load(object sender, EventArgs e)
        {
            if(allPlayer != null)
            {
                int parentPosition = 0;

                switch (Parent.Name.ToString())
                {
                    case "pnl_Save1":
                        parentPosition = 0;
                        break;

                    case "pnl_Save2":
                        parentPosition = 1;                    
                        break;

                    case "pnl_Save3":
                        parentPosition = 2;
                        break;

                }

                Font font12 = new Font(FunctionsLibs.Font_Alkhemikal, 12);
                Font font10 = new Font(FunctionsLibs.Font_Alkhemikal, 10);

                this.playerIndex = int.Parse(allPlayer[parentPosition]["Id_Player"].ToString());
           
                this.lbl_Pseudo.Font = font12;
                this.lbl_Pseudo.Text = allPlayer[parentPosition]["playerName"].ToString();

                this.lbl_Level.Font = font12;
                this.lbl_Level.Text = allPlayer[parentPosition]["level"].ToString();

                this.lbl_Hp.Font = font12;
                this.lbl_Hp.Text = allPlayer[parentPosition]["hp"].ToString();

                this.lbl_Atk.Font = font12;
                this.lbl_Atk.Text = (int.Parse(allPlayer[parentPosition]["damage"].ToString()) + int.Parse(allPlayer[parentPosition]["additionalDamage"].ToString())).ToString();

                this.lbl_IntEnd.Font = font12;

                if (allPlayer[parentPosition]["classes"].ToString() == "mage")
                {
                    this.lbl_IntEnd.Text = allPlayer[parentPosition]["intelligence"].ToString();
                }
                else
                {
                    this.lbl_IntEnd.Text = allPlayer[parentPosition]["endurance"].ToString();
                }

                this.lbl_Niv.Font = font12;

                this.lbl_Date.Font = font12;
                this.lbl_DateSave.Font = font10;
                this.lbl_DateSave.Text = DateTime.Parse(allPlayer[parentPosition]["dateSave"].ToString()).ToString("dd-MM-yyyy");

                switch (allPlayer[parentPosition]["classes"])
                {
                    case "hunter":
                        this.lbl_Pseudo.ForeColor = Color.Green;
                        this.picBox_ClasseIcon.Image = Properties.Resources.Hunter_IcoC_x32;
                        this.picBoxIntEnd.Image = Properties.Resources.Endur16_Ico;
                        break;

                    case "rogue":
                        this.lbl_Pseudo.ForeColor = Color.Violet;
                        this.picBox_ClasseIcon.Image = Properties.Resources.Rogue_IcoC_x32;
                        this.picBoxIntEnd.Image = Properties.Resources.Endur16_Ico;
                        break;

                    case "warrior":
                        this.lbl_Pseudo.ForeColor = Color.Red;
                        this.picBox_ClasseIcon.Image = Properties.Resources.Warrior_IcoC_x32;
                        this.picBoxIntEnd.Image = Properties.Resources.Endur16_Ico;
                        break;

                    case "mage":
                        this.lbl_Pseudo.ForeColor = Color.LightBlue;
                        this.picBox_ClasseIcon.Image = Properties.Resources.Mage_IcoC_x32;
                        this.picBoxIntEnd.Image = Properties.Resources.Int16_Ico;
                        break;
                }
                
            }
        }



        #region Hover & Click Events

        private void UC_LoadGameWithSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> player = allPlayer.Find(x => x["Id_Player"].ToString() == this.playerIndex.ToString());
            Player p1;
            try
            {
                p1 = new Player(player["playerName"].ToString(), player["classes"].ToString(), int.Parse(player["level"].ToString()), int.Parse(player["xp"].ToString()), int.Parse(player["hp"].ToString()), int.Parse(player["maxHp"].ToString()), int.Parse(player["damage"].ToString()), int.Parse(player["additionalDamage"].ToString()), int.Parse(player["endurance"].ToString()), int.Parse(player["intelligence"].ToString()), int.Parse(player["gold"].ToString()), int.Parse(player["fightNumber"].ToString()), int.Parse(player["Id_Player"].ToString()), DateTime.Parse(player["dateSave"].ToString()));
            }
            catch
            {
                p1 = new Player(player["playerName"].ToString(), player["classes"].ToString(), int.Parse(player["level"].ToString()), int.Parse(player["xp"].ToString()), int.Parse(player["hp"].ToString()), int.Parse(player["maxHp"].ToString()), int.Parse(player["damage"].ToString()), int.Parse(player["additionalDamage"].ToString()), int.Parse(player["endurance"].ToString()), int.Parse(player["endurance"].ToString()), int.Parse(player["gold"].ToString()), int.Parse(player["fightNumber"].ToString()), int.Parse(player["Id_Player"].ToString()), DateTime.Parse(player["dateSave"].ToString()));
            }

            //!Création d'une nouvelle fenêtre de jeu
            GameForm GameForm = new GameForm();
            GameForm.CurrentPlayer = p1;

            //! Close the current form and open the game form
            //
            Thread GameForm_THREAD = new Thread(() => Application.Run(GameForm));

            GameForm_THREAD.Start();
            this.ParentForm.Dispose();  //! Fermeture du LoginForm et libération des ressources
        }

        private void UC_LoadGameWithSave_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = this.onHover_Back;
            changeCursor();
        }

        private void UC_LoadGameWithSave_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = this.normal_Back;
            resetCursor();
        }

        #endregion

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
