using MagicDestroyers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public class Character
    {
        private int healthPoint;
        private int level;
        private Faction faction;
        private string name;


        public int HealthPoint
        {
            get
            {
                return healthPoint;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    healthPoint = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Value should be greater than 0 and less than or equal to 120");
                }
            }
        }

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                if (value >= 0)
                {
                    healthPoint = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Value should be greater than 0");
                }
            }
        }

        public Faction Faction
        {
            get
            {
                return faction;
            }
            set
            {
                faction = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Name should be between 3 and 12 characters.");
                }
            }
        }

        




    }
}
