using Lynaar_GUI.Classes;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FunctionsLibs.add_UControls(new UC_LoginMainMenu(), this.Parent);

        }
    }
}
