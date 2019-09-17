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

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage:Spellcaster
    {
        private const int HEALTH_POINTS = 120;
        private const int LEVEL = 1;
        private const Faction FACTION = Faction.Spellcaster;
        private const string NAME="Merlin";
        private const int MANA_POINTS = 100;

        private readonly ClothRobe BODY_ARMOR = new ClothRobe();
        private readonly Staff WEAPON = new Staff();

        private ClothRobe bodyArmor;       
        private Staff weapon;

        public ClothRobe BodyArmor
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

        public ClothRobe Weapon
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

        public Mage():this(NAME,LEVEL)
        {

        }

        public Mage(string name, int level)
            :this(name,level,HEALTH_POINTS)
        {
        }

        public Mage(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoint = healthPoints;
            Manapoints = MANA_POINTS;
            Faction = FACTION;
            BodyArmor = BODY_ARMOR;
            Weapon = WEAPON;

        }

        public void Fireball()
        {
            throw new NotImplementedException();
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
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
