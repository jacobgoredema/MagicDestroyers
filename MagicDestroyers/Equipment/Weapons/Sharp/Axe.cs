using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe:Sharp
    {
        private const int DAMAGE_POINTS = 10;
        private int dAMAGE_POINTS;

        public Axe():this(DAMAGE_POINTS)
        {

        }

        public Axe(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
