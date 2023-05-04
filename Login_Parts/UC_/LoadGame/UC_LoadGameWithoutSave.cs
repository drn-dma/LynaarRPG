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
    public partial class UC_LoadGameWithoutSave : UserControl
    {
        #region Attributs

        Form ParentForm;

        #endregion

        public UC_LoadGameWithoutSave(Form parent)
        {
            InitializeComponent();

            this.ParentForm = parent;
        }

        private void UC_LoadGameWithoutSave_Load(object sender, EventArgs e)
        {
            lbl_Empty.Font = new Font(FunctionsLibs.Font_Alkhemikal, 20);
        }
    }
}
