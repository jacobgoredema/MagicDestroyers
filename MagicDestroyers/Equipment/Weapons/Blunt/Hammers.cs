using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammers:Blunt
    {
        private const int DAMAGE_POINTS = 10;
        private int dAMAGE_POINTS;

        public Hammers():this(DAMAGE_POINTS)
        {

        }

        public Hammers(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
