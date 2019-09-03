using MagicDestroyers.Enums;
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
        private const string Default_Name = "Bob";
        private const int Default_Level = 1;
        private const int default_health_Points = 120;
        private const Faction Default_Faction = Enums.Faction.Melee;
        private const int Ability_Points = 100;

        private int abilityPoints;
        private int healthPoint;
        private int level;
        private Faction faction;
        private string name;

        private Chainlink bodyArmor;
        private Axe weapon;

        public Warrior():this(Default_Name,Default_Level)
        {
        }

        public Warrior(string name, int level):this(name,level,default_health_Points)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoint = healthPoint;

            AbilityPoints = Ability_Points;
            faction = Default_Faction;
            BodyArmor = new Chainlink();
            Weapon = new Axe();
        }

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

        public Axe Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon=value;
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
