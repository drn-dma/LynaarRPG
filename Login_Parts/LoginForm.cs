using Lynaar_GUI.Classes;
using Lynaar_GUI.Login_Parts.UC_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoggingForm_Load(object sender, EventArgs e)
        {
            //! Ajout de l'UC (UserControl) UC_LoginMainMenu dans le panel 'pnl_LoginMain' au chargement du Formulaire
            FunctionsLibs.add_UControls(new UC_LoginMainMenu(), pnl_LoginMain);
            
        }                 
    }
}
