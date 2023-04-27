using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynaar_GUI.Classes
{
    internal class Equipement
    {
        #region private variable

        private int id;
        private string name;
        private string description;
        private int rarity;
        private int pv;
        private int atk;
        private int price;
        private bool isEquiped;
        private bool isWeapon;

        #endregion

        #region Constructeur
        //constructor
        public Equipement(string name, string description, int rarity, int pv, int atk, int price, bool isEquiped, bool isWeapon, int id)
        {
            this.name = name;
            this.description = description;
            this.rarity = rarity;
            this.pv = pv;
            this.atk = atk;
            this.price = price;
            this.isEquiped = isEquiped;
            this.isWeapon = isWeapon;
            this.id = id;
        }

        #endregion

        #region accesseur
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Rarity { get => rarity; set => rarity = value; }
        public int Pv { get => pv; set => pv = value; }
        public int Atk { get => atk; set => atk = value; }
        public int Price { get => price; set => price = value; }
        public bool IsEquiped { get => isEquiped; set => isEquiped = value; }
        public bool IsWeapon { get => isWeapon; set => isWeapon = value; }
        public int Id { get => id; set => id = value; }

        #endregion

        #region Function

        #endregion

        #region methods


        #endregion
    }
}