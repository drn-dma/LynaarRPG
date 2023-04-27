using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynaar_GUI.Classes
{
    internal class Player
    {
        
        #region private variable
        private int id;
        private string PlayerName;
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

        #endregion

        #region Constructeur

        //constructor
        public Player(string PlayerName, string classe, int level, int experience, int hp, int maxHp, int damage, int additionalDamage, int endurance, int intelligence, int gold, int fightNumber, int id)
        {
            this.PlayerName = PlayerName;
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
        }

        #endregion

        #region accesseur
        public string PlayerName1 { get => PlayerName; set => PlayerName = value; }
        public string Classe { get => classe; set => classe = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public int Hp { get => hp; set => hp = value; }
        public int MaxHp { get => maxHp; set => maxHp = value; }
        public int Damage { get => damage; set => damage = value; }
        public int AdditionalDamage { get => additionalDamage; set => additionalDamage = value; }
        public int Endurance { get => endurance; set => endurance = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Gold { get => gold; set => gold = value; }
        public int FightNumber { get => fightNumber; set => fightNumber = value; }
        public int Id { get => id; set => id = value; }
        #endregion

        #region Function

        #endregion

        #region methods


        #endregion

    }
}
