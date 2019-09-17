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
    public class Warrior:Melee
    {
        private const string Default_Name = "Bob";
        private const int Default_Level = 1;
        private const int default_health_Points = 120;
        private const Faction Default_Faction = Enums.Faction.Melee;
        private const int Ability_Points = 100;


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
