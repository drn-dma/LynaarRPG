using Lynaar_GUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI
{
    public partial class GameForm : Form
    {

        //! Initialisation des polices
        private Font font10;
        private Font font12;
        private Font font15;
        private Font font20;

        //lien de 1 à 1 avec player
        private Player currentPlayer;

        internal Player CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public GameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.font10 = new Font(FunctionsLibs.Font_Alkhemikal, 10);
            this.font12 = new Font(FunctionsLibs.Font_Alkhemikal, 12);
            this.font15 = new Font(FunctionsLibs.Font_Alkhemikal, 15);
            this.font20 = new Font(FunctionsLibs.Font_Alkhemikal, 20);


        #region Affichage des informations du joueur

        //!Affichage de l'avatar de la classe en fonction de la classe du joueur
            switch (this.currentPlayer.Classe)
            {
                case "Warrior":
                    picBoxAvatar.BackgroundImage = Properties.Resources.Warrior_Ico;
                    lblName.ForeColor = Color.Red;
                    break;
                case "Mage":
                    picBoxAvatar.BackgroundImage = Properties.Resources.Mage_Ico;
                    lblName.ForeColor = Color.Blue;
                    break;
                case "Rogue":
                    picBoxAvatar.BackgroundImage = Properties.Resources.Rogue_Ico;
                    lblName.ForeColor = Color.Purple;
                    break;
                case "Hunter":
                    picBoxAvatar.BackgroundImage = Properties.Resources.Hunter_Ico;
                    lblName.ForeColor = Color.Green;
                    break;
            }

            //! remplissage des labels avec les infos du joueur
            lblName.Text = this.currentPlayer.PlayerName1;
            lblLevel.Text ="LvL : " + this.currentPlayer.Level.ToString();
            lblGold.Text = this.currentPlayer.Gold.ToString();
            lblXp.Text = this.currentPlayer.Experience.ToString();
            lblHp.Text = this.currentPlayer.Hp.ToString();
            lblAtk.Text = this.currentPlayer.Damage.ToString();
            lblFloor.Text = this.currentPlayer.FightNumber.ToString();
            lblNextBossFloor.Text = this.currentPlayer.FightNumber.ToString();

            //! Application de la police aux labels
            lblName.Font = font20;
            lblLevel.Font = font15;
            lblGold.Font = font15;
            lblXp.Font = font15;
            lblHp.Font = font15;
            lblAtk.Font = font15;
            lblFloor.Font = font15;
            lblNextBossFloor.Font = font15;
            lblIntAndEnd.Font = font15;



            //! réglage de l'affichage du boss floor pour afficher la prochaine dizaine d'étages
            lblNextBossFloor.Text = "10";
            if (this.currentPlayer.FightNumber % 10 == 0)
            {
                lblNextBossFloor.Text = (this.currentPlayer.FightNumber + 10).ToString();
            }


            //! réglage de l'affichage de l'endure ou de l'int en fonction de la classe
            if (this.currentPlayer.Classe == "Mage")
            {
                picBoxIntAndEnd.BackgroundImage = Properties.Resources.Int32_Ico;
                lblIntAndEnd.Text = this.currentPlayer.Intelligence.ToString();
            }
            else
            {
                lblIntAndEnd.Text = this.currentPlayer.Endurance.ToString();
            }
            #endregion

        }

        #region Gestion des boutons du menu
        //! Fonction affichage des UC (UserControl) dans le panel principal 'pnl_Main' en fonction du bouton cliqué
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //! Récupération de l'objet cliqué (sender) et conversion en PictureBox
            PictureBox btn = (PictureBox)sender;

            //! Switch en fonction du nom du bouton cliqué
            switch(btn.Name)
            {
                case "picBox_Inventory":
                    FunctionsLibs.add_UControls(new UC_GameInventory(),pnl_Main);
                    break;
            }

            
        }
        #endregion

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void table_MenuButton_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
