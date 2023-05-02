using Lynaar_GUI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI.Classes
{
    internal static class FunctionsLibs
    {


        private static int fontLength = Resources.Font_Alkhemikal.Length;
        private static byte[] fontdata = Resources.Font_Alkhemikal;





        #region add_UControls Methods

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


        //! Fonction alternative utilisant un Control à la place d'un Panel
        public static void add_UControls(UserControl uc, Control control)
        {
           
            uc.Dock = DockStyle.Fill;       //! Permet de remplir le panel avec l'UC
            control.Controls.Clear();
            control.Controls.Add(uc);
            uc.BringToFront();
        }

        #endregion

        

       /* //! Ajout de la police Alkhemikal dans le projet
        public static FontFamily getFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            
            return pfc.Families[0];
            
        }*/

        

       
    }
}
