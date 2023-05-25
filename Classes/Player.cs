using System;
using Lynaar_GUI.Classes.Miscellaneous;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace Lynaar_GUI.Classes
{
    internal class Player
    {
        
        #region private variable
        private int id;
        private string playerName;
        private string classe;
        private int level;
        private int experience;
        private int hp;
        private int maxHp;
        private int damage;
        private int additionalDamage;
        private int endurance;
        private int intelligence;
        private int gold;
        private int fightNumber;
        private DateTime lastSave;
        private int maxExperience;
        private Color classeColor;
        private bool isDead;
        private int[] xpGap;

        Random rnd;
        #endregion

        #region Constructeur

        //constructor

        //? Exemple Cosntructeur
        //todo  new Player(player["playerName"].ToString(), player["classes"].ToString(), int.Parse(player["level"].ToString()), int.Parse(player["xp"].ToString()), int.Parse(player["hp"].ToString()), int.Parse(player["maxHp"].ToString()), int.Parse(player["damage"].ToString()), int.Parse(player["additionalDamage"].ToString()), int.Parse(player["endurance"].ToString()), int.Parse(player["intelligence"].ToString()), int.Parse(player["gold"].ToString()), int.Parse(player["fightNumber"].ToString()), int.Parse(player["Id_Player"].ToString()));


        public Player(string PlayerName, string classe, int level, int experience, int hp, int maxHp, int damage, int additionalDamage, int endurance, int intelligence, int gold, int fightNumber, int id, DateTime lastSave/*, int? maxXp*/)
        {
            this.playerName = PlayerName;
            this.classe = classe;
            this.level = level;
            this.experience = experience;
            this.hp = hp;
            this.maxHp = maxHp;
            this.damage = damage;
            this.additionalDamage = additionalDamage;
            this.endurance = endurance;
            this.intelligence = intelligence;
            this.gold = gold;
            this.fightNumber = fightNumber;
            this.id = id;
            this.lastSave = lastSave;
            this.rnd = new Random();
            this.isDead = false;
            this.xpGap = totalXpPerLvl();
            this.maxExperience = xpGap[level];

            switch(classe)
            {
                case "hunter":
                    this.classeColor = Color.Green;
                    break;
                case "warrior":
                    this.classeColor = Color.Red;
                    break;
                case "sorcerer":
                    this.classeColor = Color.Blue;
                    break;
                case "rogue":
                    this.classeColor = Color.Purple;
                    break;
            }
            /*            this.maxExperience = maxXp;
            */
        }

        #endregion

        #region accesseur
        public string PlayerName { get => playerName; set => playerName = value; }
        public string Classe { get => classe; set => classe = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public int MaxExperience { get => maxExperience; set => maxExperience = value; }
        public int Hp { get => hp; set => hp = value; }
        public int MaxHp { get => maxHp; set => maxHp = value; }
        public int Damage { get => damage; set => damage = value; }
        public int AdditionalDamage { get => additionalDamage; set => additionalDamage = value; }
        public int Endurance { get => endurance; set => endurance = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Gold { get => gold; set => gold = value; }
        public int FightNumber { get => fightNumber; set => fightNumber = value; }
        public int Id { get => id; set => id = value; }
        public Color ClasseColor { get => classeColor; set => classeColor = value; }
        public DateTime LastSave { get => lastSave; set => lastSave = value; }
        public bool IsDead { get => isDead; set => isDead = value; }
        #endregion

        #region Function


        private int[] totalXpPerLvl()
        {
            int[] maxXp = new int[101];
            int[] returned = new int[101];

            for (int i = 0; i <= 100; i++)
            {
                maxXp[i] = (int)Math.Floor(100 * Math.Pow(i, 2.7));
            }

            returned[0] = 0;

            for(int i = 1; i < maxXp.Length; i++)
            {
                returned[i] = maxXp[i] - maxXp[i-1];
            }
            return returned;
        }



        
        //!fonction qui permet de calculer les dégats du joueur
        public int calculateDamage()
        {            
            int damage = this.damage + this.additionalDamage + (this.rnd.Next(Settings.PLAYER_DAMAGE_REDUCE,Settings.PLAYER_DAMAGE_BOOST));
            return damage;
        }


        //!fonction attack
        public int basicAttack(Monstre monstre)
        {
            int damage = calculateDamage();


            if (monstre.Hp - damage < 0)
            {
                monstre.Hp = 0;
                monstre.IsDead = true;
            }
            else
            {
                monstre.Hp -= damage;
            }
            
            return damage;
        }


        public void GainExp(Monstre monstre)
        {
            
            this.experience += Settings.SUIVI_GAIN_XP(monstre);
            if (this.experience >= this.maxExperience)
            {
                LvlUp();
            }
        }


        private void LvlUp()
        {
            int xpRestant = this.experience + this.maxExperience;
            this.level++;
            this.MaxHp = Settings.SUIVI_HPMAX_JOUEUR(this);
            this.damage += Settings.SUIVI_DAMAGE_JOUEUR(this.damage);
            this.maxExperience = xpGap[this.level];
            xpRestant -= this.maxExperience;
            this.experience = xpRestant;
        }

        #endregion

        #region methods


        #endregion

    }
}
