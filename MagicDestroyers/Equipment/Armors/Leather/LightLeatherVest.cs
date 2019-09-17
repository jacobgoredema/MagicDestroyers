using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LightLeatherVest:Leather
    {
        private const int ARMOR_POINTS = 10;

        public LightLeatherVest():this(ARMOR_POINTS)
        {

        }

        public LightLeatherVest(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
