using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Classes
{
    internal static class FunctionsLibs
    {



        /// <summary>
        //! Ajout d'un UserControl 'uc' dans un Panel 'panelObject' et le met au premier plan (BringToFront) 
        //// </summary>
        /// <param name="uc"></param>
        /// <param name="panelObject"></param>
        public static void add_UControls(UserControl uc, Panel panelObject)
        {
            uc.Dock = DockStyle.Fill;       //! Permet de remplir le panel avec l'UC
            panelObject.Controls.Clear();
            panelObject.Controls.Add(uc);
            uc.BringToFront();
        }

        //! Ajout de la police Alkhemikal dans le projet
        private static PrivateFontCollection initFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.Font_Alkhemikal.Length;
            byte[] fontdata = Properties.Resources.Font_Alkhemikal;

            IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);

            return pfc;
        }

        //! Change la police d'un label 'lbl' avec la police Alkhemikal et la taille 'size'
        public static void setFont(Label lbl, int size)
        {
            lbl.Font = new Font(initFont().Families[0], size, FontStyle.Regular);
        }

    }
}
