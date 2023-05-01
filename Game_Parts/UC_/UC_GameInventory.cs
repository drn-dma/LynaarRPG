﻿using Lynaar_GUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lynaar_GUI
{
    public partial class UC_GameInventory : UserControl
    {

        private Font font40;


        public UC_GameInventory()
        {
            InitializeComponent();
            
            this.font40 = new Font(FunctionsLibs.getFont(),40);
            
        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            //! Modification de la police de caractère du label 'lbl_Inventaire' au chargement de l'UC
            this.lbl_Inventaire.Font = font40;
        }

        private void lbl_Inventaire_Click(object sender, EventArgs e)
        {

        }
    }
}
