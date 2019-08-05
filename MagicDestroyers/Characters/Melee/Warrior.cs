using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        private int abilityPoints;
        private int healthPoint;
        private int level;
        private string faction;
        private string name;

        private Chainlink bodyArmor;
        private Axe weapon;

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if(value>=0 && value<=10)
                {
                    abilityPoints = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Value should be greater than 0 and less than or equal to 10");
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
                if (value>=0 && value<=120)
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
                if (value>=0)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Value should be greater than 0");
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
                if (value.ToLower()=="Melee" || value.ToLower()=="Spellcaster")
                {
                    faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The faction should either be Melee or Spellcaster");
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
                if (value.Length>=3 && value.Length<=12)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Name should be between 3 and 12 characters.");
                }
            }
        }

        public Warrior()
        {


        }

        public void Execute()
        {

        }

        public void SkinHarden()
        {

        }

        public void Strike()
        {

        }




    }
}
