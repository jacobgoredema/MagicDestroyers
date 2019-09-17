using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink:Heavy
    {
        private const int ARMOR_POINTS = 10;
        private int aRMOR_POINTS;

        public Chainlink():this(ARMOR_POINTS)
        {

        }

        public Chainlink(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
