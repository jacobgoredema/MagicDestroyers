using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe
    {
        private int armorpoints;

        public int Armorpoints
        {
            get
            {
                return armorpoints;
            }
            set
            {
                if (value >= 0)
                {
                    value = armorpoints;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armour points value should be a positive number");
                }
            }
        }

        public ClothRobe()
        {

        }        
    }
}
