using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Assasin:Melee
    {
        private const int ABILITYPOINTS = 100;
        private const int HEALTHPOINTS = 120;
        private const int LEVEL = 1;
        private const Faction FACTION=Faction.Melee;
        private const string NAME = "Snark";

        private readonly Sword WEAPON= new Sword();
        private readonly LightLeatherVest BODY_ARMOR= new LightLeatherVest();

        private LightLeatherVest bodyArmor;
        private Sword weapon;

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

        public Assasin():this(NAME,LEVEL)
        {

        }

        public Assasin(string name, int level)
            :this(name,level,HEALTHPOINTS)
        {
        }

        public Assasin(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoint = healthPoints;
            AbilityPoints = ABILITYPOINTS;
            Faction = FACTION;
            BodyArmor = BODY_ARMOR;
            Weapon = WEAPON;
        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
