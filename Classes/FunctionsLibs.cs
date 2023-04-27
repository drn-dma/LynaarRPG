using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Classes
{
    internal static class FunctionsLibs
    {

        //! Ajout d'un UserControl 'uc' dans un Panel 'panelObject' et le met au premier plan (BringToFront) 
        public static void add_UControls(UserControl uc, Panel panelObject)
        {
            uc.Dock = DockStyle.Fill;
            panelObject.Controls.Clear();
            panelObject.Controls.Add(uc);
            uc.BringToFront();
        }




    }
}
