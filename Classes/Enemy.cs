using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynaar_GUI.Classes
{
    internal class Enemy
    {

        #region private variable

        private int id;
        private string name;
        private int hp;
        private int xp;
        private int dmgMin;
        private int dmgMax;
        private int goldMin;
        private int goldMax;

        #endregion

        #region Constructeur

        //constructor
        public Enemy(int id, string name, int hp, int xp, int dmgMin, int dmgMax, int goldMin, int goldMax)
        {
            this.id = id;
            this.name = name;
            this.hp = hp;
            this.xp = xp;
            this.dmgMin = dmgMin;
            this.dmgMax = dmgMax;
            this.goldMin = goldMin;
            this.goldMax = goldMax;
        }
        #endregion

        #region accesseur
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Xp { get => xp; set => xp = value; }
        public int DmgMin { get => dmgMin; set => dmgMin = value; }
        public int DmgMax { get => dmgMax; set => dmgMax = value; }
        public int GoldMin { get => goldMin; set => goldMin = value; }
        public int GoldMax { get => goldMax; set => goldMax = value; }

        #endregion

    }
}
