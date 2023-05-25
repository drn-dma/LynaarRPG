using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynaar_GUI.Classes
{
    internal class Boss : Enemy
    {
        //private variable
        private Equipement _equipement;
        private int idEquipement;

        //constructor
        public Boss(int id, string name, int hp, int xp, int dmgMin, int dmgMax, int goldMin, int goldMax, Equipement equipement, int level) : base(id, name, hp, xp, dmgMin, dmgMax, goldMin, goldMax, level)
        {
            this._equipement = equipement;
        }

        public Boss(Dictionary<string, object> keyValuePairs, int level) : base(keyValuePairs, level)
        {
            this.idEquipement = (int)keyValuePairs["Id_Equipement"];
        }
    }
}
