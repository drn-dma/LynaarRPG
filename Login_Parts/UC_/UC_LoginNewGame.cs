using Lynaar_GUI.Classes;

using Lynaar_GUI.Properties;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Login_Parts.UC_
{
    public partial class UC_LoginNewGame : UserControl
    {

        public UC_LoginNewGame()
        {
            InitializeComponent();
        }

        private void UC_LoginNewGame_Load(object sender, EventArgs e)
        {
         
            FunctionsLibs.setFont(lblWho, 15);
            FunctionsLibs.setFont(lblClassName, 10);
            FunctionsLibs.setFont(lblWhat, 15);
            FunctionsLibs.setFont(lblName, 10);
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {          
            Thread GameForm_THREAD = new Thread(new ThreadStart(openGameForm));
            GameForm_THREAD.Start();

            ((Form)this.TopLevelControl).Close();
        }

        private void openGameForm()
        {
            Application.Run(new GameForm());
        }


        private void rbClasseHunter_CheckedChanged(object sender, EventArgs e)
        {
            lblClassName.Text = "HUNTER";
            lblClassName.ForeColor = Color.Green;
            lblClassName.TextAlign = ContentAlignment.TopCenter;
        }

        private void rdbClasseWarrior_CheckedChanged(object sender, EventArgs e)
        {
            lblClassName.Text = "WARRIOR";
            lblClassName.ForeColor = Color.Red;
            lblClassName.TextAlign = ContentAlignment.TopCenter;
        }

        private void rbClasseRogue_CheckedChanged(object sender, EventArgs e)
        {
            lblClassName.Text = "ROGUE";
            lblClassName.ForeColor = Color.Violet;
            lblClassName.TextAlign = ContentAlignment.TopCenter;
        }
        private void rdClasseMage_CheckedChanged(object sender, EventArgs e)
        {
            lblClassName.Text = "MAGE";
            lblClassName.ForeColor = Color.LightBlue;
            lblClassName.TextAlign = ContentAlignment.TopCenter;
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            
        }

        private void lblWho_Click(object sender, EventArgs e)
        {
            
        }

        private void lblWhat_Click(object sender, EventArgs e)
        {
        
        }
    }
}
