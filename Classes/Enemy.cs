using Lynaar_GUI.Classes.Miscellaneous;
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
        private bool isDead;
        private Random rnd;
        private int lvl;

        #endregion

        #region Constructeur

        //constructor
        public Enemy(int id, string name, int hp, int xp, int dmgMin, int dmgMax, int goldMin, int goldMax, int lvl)
        {
            this.id = id;
            this.name = name;
            this.lvl = lvl;
            this.hp = hp + Settings.SUIVI_VIE_MONSTRE(this.lvl);
            this.xp = xp;
            this.dmgMin = dmgMin + Settings.SUIVI_DAMAGE_MONSTRE(this.lvl);
            this.dmgMax = dmgMax + Settings.SUIVI_DAMAGE_MONSTRE(this.lvl);
            this.goldMin = goldMin;
            this.goldMax = goldMax;
            
            this.isDead = false;
            rnd = new Random();
        }

        public Enemy(Dictionary<string, object> keyValuePairs, int lvl)
        {
            this.id = int.Parse(keyValuePairs["Id_Entity"].ToString());
            this.name = keyValuePairs["name"].ToString();
            this.lvl = lvl;
            this.hp = int.Parse(keyValuePairs["hp"].ToString()) + Settings.SUIVI_VIE_MONSTRE(this.lvl);
            this.xp = int.Parse(keyValuePairs["xp"].ToString());
            this.dmgMin = int.Parse(keyValuePairs["dmgMin"].ToString()) + Settings.SUIVI_DAMAGE_MONSTRE(this.lvl);
            this.dmgMax = int.Parse(keyValuePairs["dmgMax"].ToString()) + Settings.SUIVI_DAMAGE_MONSTRE(this.lvl);
            this.goldMin = int.Parse(keyValuePairs["goldMin"].ToString());
            this.goldMax = int.Parse(keyValuePairs["goldMax"].ToString());
            this.isDead = false;
            
            rnd = new Random();
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
        public bool IsDead { get => isDead; set => isDead = value; }
        public int Level { get => lvl; set => lvl = value; }
        #endregion



        #region methodes

        private int calculDmg()
        {
            return this.rnd.Next(this.dmgMin, this.dmgMax);
        }

        public int attack(Player player)
        {
            int dmg = calculDmg();

            if (player.Hp - dmg < 0)
            {
                player.Hp = 0;
                player.IsDead = true;
            }
            else
            {
                player.Hp -= dmg;

            }

            return dmg;
        }

        #endregion
    }
}
