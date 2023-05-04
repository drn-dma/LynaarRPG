using Lynaar_GUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Login_Parts.UC_.LoadGame
{
    public partial class UC_LoadGameWithSave : UserControl
    {

       private Form parentForm;
        private List<Dictionary<string, object>> allPlayer = null;
        private int playerIndex;
 
        public UC_LoadGameWithSave(Form parent, List<Dictionary<string, object>> players) //todo Enlever le commentaire pour introduire le sql
        {
            InitializeComponent();

            parentForm = parent;

            allPlayer = players;

            
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

        private void UC_LoadGameWithSave_Click(object sender, EventArgs e)
        {
            this.parentForm.Hide();
            Form gameForm = new GameForm(/*allPlayer[playerIndex]*/);
            gameForm.Show();
        }
    }
}
