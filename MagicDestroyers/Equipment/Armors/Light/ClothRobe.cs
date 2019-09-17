using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe:Light
    {
        private const int ARMOR_POINTS = 10;

        public ClothRobe():this(ARMOR_POINTS)
        {

        }

        public ClothRobe(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }

        public static implicit operator ClothRobe(Staff v)
        {
            throw new NotImplementedException();
        }
    }
}
