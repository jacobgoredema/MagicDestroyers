﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink
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
                    value = armorPoints;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor points must be a positive number");
                }
            }
        }

        public Chainlink()
        {

        }


    }
}
