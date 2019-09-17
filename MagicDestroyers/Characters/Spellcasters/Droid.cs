using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Droid:Spellcaster
    {
        private const int MANA_POINTS = 100;
        private const int HEALTH_POINTS =120;
        private const int LEVEL =1;
        private const Faction FACTION=Faction.Spellcaster;
        private const string NAME="Cenarius";

        private readonly LightLeatherVest BODY_ARMOR = new LightLeatherVest();
        private readonly Staff WEAPON = new Staff();

        private Staff weapon;
        private LightLeatherVest bodyArmor;
        private string name1;
        private int level1;
        private int hEALTH_POINTS;

        public Droid():this(NAME,LEVEL)
        {

        }

        public Droid(string name, int level)
            :this(name,level,HEALTH_POINTS)
        {
        }

        public Droid(string name, int level, int healthPoints)
        {
            Name = name;
            level1 = level;
            HealthPoint = healthPoints;
            Manapoints = MANA_POINTS;
            Faction = FACTION;
            BodyArmor = BODY_ARMOR;
            Weapon = WEAPON;
        }

        public LightLeatherVest BodyArmor
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
        

        public Staff Weapon
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


        public void MoonFire()
        {
            throw new NotImplementedException();
        }

        public void StarBurst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}
