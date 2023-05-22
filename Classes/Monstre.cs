using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynaar_GUI.Classes
{
    internal class Monstre : Enemy
    {

        //constructor
        public Monstre(int id, string name, int hp, int xp, int dmgMin, int dmgMax, int goldMin, int goldMax) : base(id, name, hp, xp, dmgMin, dmgMax, goldMin, goldMax)
        {
        }


        public Monstre(Dictionary<string, object> keyValuePairs) : base(keyValuePairs)
        {

        }
    }
}
