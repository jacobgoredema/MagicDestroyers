using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight
    {
        private int abilityPoints;
        private int healthPoint;
        private int level;
        private string faction;
        private string name;
        private Chainlink bodyArmor;
        private Hammers weapon;

        public Chainlink BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }

        private Hammers Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    abilityPoints=value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value must be above 0 and 10");
                }
            }
        }

        public int HealthPoint
        {
            get
            {
                return healthPoint;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    healthPoint = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value must be between 0 and 100");
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
                    throw new ArgumentOutOfRangeException(string.Empty, "Level should be a positive value");
                }
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
                    throw new ArgumentOutOfRangeException(string.Empty, "Name should have between 3 and 12 characters");
                }
            }
        }

        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (value=="Melee" || value=="Spellcaster")
                {
                    faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty,"Faction can either be Melee or Spellcaster");
                }
            }
        }

        public Knight()
        {

        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}
