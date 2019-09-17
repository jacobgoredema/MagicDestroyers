using MagicDestroyers.Enums;
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
    public class Knight:Melee
    {
        private const int ABILITY_POINTS= 100;
        private const int HEALTH_POINTS = 120;
        private const int LEVEL = 1;
        private Faction FACTION =Faction.Melee;
        private const string NAME ="Author";

        private readonly Chainlink BODY_ARMOR = new Chainlink();
        private readonly Hammers WEAPON = new Hammers();

        private Chainlink bodyArmor;
        private Hammers weapon;
        private string nAME;
        private int lEVEL;
        private string name1;
        private int level1;
        private int hEALTH_POINTS;

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

        public Knight():this(NAME,LEVEL)
        {

        }

        public Knight(string name, int level)
            : this(name,level,HEALTH_POINTS)
        {
        }

        public Knight(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoint = healthPoints;
            AbilityPoints = ABILITY_POINTS;
            Faction = FACTION;
            BodyArmor = BODY_ARMOR;
            Weapon = WEAPON;
        }
    }
}
