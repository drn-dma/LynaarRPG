using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynaar_GUI.Classes
{
	internal class Consumables
	{
		#region private variables

		private int id;
		private string name;
		private string description;
		private int priceBuy;
		private int priceSold;
		private int maxDrop;
		private int rarity;

		#endregion private variables

		#region constructors

		// constructor
		public Consumables(int id, string name, string description, int priceBuy, int priceSold, int maxDrop, int rarity)
		{
			this.id = id;
			this.name = name;
			this.description = description;
			this.priceBuy = priceBuy;
			this.priceSold = priceSold;
			this.maxDrop = maxDrop;
			this.rarity = rarity;
		}

		#endregion constructors

		#region accessors
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int PriceBuy { get => priceBuy; set => priceBuy = value; }
        public int PriceSold { get => priceSold; set => priceSold = value; }
        public int MaxDrop { get => maxDrop; set => maxDrop = value; }
        public int Rarity { get => rarity; set => rarity = value; }

		#endregion

		#region Function

		#endregion

		#region methods


		#endregion

	}
}