﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe
    {
        private int armorPoints;

        public int Armorpoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value >= 0)
                {
                    armorPoints=value;
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
