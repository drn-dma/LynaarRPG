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

        Form parentForm;
        List<Dictionary<string, object>> allPlayer = null;

        public UC_LoadGameWithSave(Form parent, List<Dictionary<string, object>> sqlResult) //todo Enlever le commentaire pour introduire le sql
        {
            InitializeComponent();

            parentForm = parent;

            allPlayer = sqlResult;

            
        }

        private void UC_LoadGameWithSave_Load(object sender, EventArgs e)
        {
            if(allPlayer != null)
            {
                lbl_Pseudo.Text = allPlayer[0]["playerName"].ToString();
                lbl_Niveaux.Text = allPlayer[0]["level"].ToString();

                switch (allPlayer[0]["classes"])
                {
                    case "Chasseur":
                        picBox_ClasseIcon.BackgroundImage = Properties.Resources.Hunter_IcoC;
                        break;
                }
                
            }
        }
    }
}
