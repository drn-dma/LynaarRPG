using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynaar_GUI.Classes.Miscellaneous
{
    internal class Settings
    {

        public static int SUIVI_VIE_MONSTRE(int lvl_monstre)
        {
            return Convert.ToInt32(20 * lvl_monstre);
        }

        public static int SUIVI_DAMAGE_MONSTRE(int lvl_monstre)
        {
            return Convert.ToInt32(1.5 * lvl_monstre);
        }

        public static int SUIVI_DAMAGE_JOUEUR(int actualDamage)
        {
            return Convert.ToInt32((actualDamage * 0.1d));
        }

        public static int SUIVI_GAIN_XP(Player player, Monstre monstre)
        {
            double gain = Math.Floor(player.Level + 200d * Math.Pow(2d, player.Level / 7d) * (monstre.Xp / 4d));
            gain = Math.Floor(gain / 10d);

            return Convert.ToInt32(gain);
        }

        public static int SUIVI_HPMAX_JOUEUR(Player player)
        {
            return Convert.ToInt32(player.MaxHp * 0.1d);
        }

        /////
        //// Dégats aléatoire entre les deux variables
        ///

        public static int PLAYER_DAMAGE_REDUCE = -5;

        public static int PLAYER_DAMAGE_BOOST = 4;
        //////////////////////
        ///
    }
}
