using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer:Spellcaster
    {
        private const string NAME = "Necromus";
        private const int HEALTH_POINTS = 120;
        private const int LEVEL = 1;
        private const Faction FACTION = Faction.Spellcaster;
        private const int MANA_POINTS = 100;

        private LightLeatherVest bodyArmor;
        private Sword weapon;

        private readonly LightLeatherVest BODYARMOR = new LightLeatherVest();
        private readonly Sword WEAPON = new Sword();

        private LightLeatherVest BodyArmor
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

        public Sword Weapon
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

        public Necromancer():this(NAME,LEVEL)
        {

        }

        public Necromancer(string name, int level)
            :this(name,level,HEALTH_POINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoint = healthPoints;
            Manapoints = MANA_POINTS;
            Faction = FACTION;
            BodyArmor = BODYARMOR;
            Weapon = weapon;
        }

        public void ShadowRange()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}
