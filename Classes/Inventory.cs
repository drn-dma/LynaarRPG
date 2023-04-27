using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynaar_GUI.Classes
{
    internal class Inventory
    {

        #region private variable
        private int id;
        private bool isEquiped;

        #endregion

        #region Constructeur

        //constructor
        public Inventory(int id, bool isEquiped)
        {
            this.id = id;
            this.isEquiped = isEquiped;
        }

        #endregion

        #region accesseur
        public int Id { get => id; set => id = value; }
        public bool IsEquiped { get => isEquiped; set => isEquiped = value; }

        #endregion
    }
}
