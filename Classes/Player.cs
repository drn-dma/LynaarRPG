using System;
using Lynaar_GUI.Classes.Miscellaneous;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
            setLimiteXP();
            this.rnd = new Random();
            this.isDead = false;

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

        private void setLimiteXP()
        {
            double limit = 0d;

            for (int i = 0; i < this.level; i++)
            {
                limit += Math.Floor(i + 200d * Math.Pow(2d, (i / 2d)));

            }
            limit = Math.Floor(limit / 4d);
            this.maxExperience = Convert.ToInt32(limit);
        }


        //fonction qui définie les stats du joueur en fonction de sa classe
        public void setPlayerStats(string classe)
        {
            switch (classe)
            {
                case "Hunter":
                    this.hp = 100;
                    this.endurance = 10;
                    this.intelligence = 5;
                    this.damage = this.endurance * 1/2;
                    break;
                case "Warrior":
                    this.hp = 150;
                    this.endurance = 15;
                    this.intelligence = 0;
                    this.damage = this.endurance * 1/2;
                    break;
                case "Mage":
                    this.hp = 75;
                    this.endurance = 0;
                    this.intelligence = 15;
                    this.damage = this.intelligence * 1/2;
                    break;
                default:
                    break;
            }
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


        public void GainExp(int exp)
        {
            
            this.experience += exp;
            if (this.experience >= this.maxExperience)
            {
                this.experience -= this.maxExperience;
                this.level++;
                this.maxExperience = (int)(this.maxExperience * 1.5);
            }
        }
        #endregion

        #region methods


        #endregion

    }
}
