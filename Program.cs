﻿using Lynaar_GUI.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            //! Personnal Function

            //! Initialisation des objets Player dans un 2nd Thread
            var allPlayer = FunctionsLibs.initPlayer();

            FunctionsLibs.getFont();


            Application.Run(new LoginForm(allPlayer));
            
        }

        
    }
}
