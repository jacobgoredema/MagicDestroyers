using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword:Sharp
    {
        private const int DAMAGE_POINTS=10;
        private int dAMAGE_POINTS;

        public Sword():this(DAMAGE_POINTS)
        {

        }

        public Sword(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public void BloodThirst()
        {
            throw new NotImplementedException();
        }
    }
}
