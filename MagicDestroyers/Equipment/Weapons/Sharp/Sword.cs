using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword
    {
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value>0)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage valuw should be a positive number");
                }
            }
        }

        public Sword()
        {

        }

        public void BloodThirst()
        {
            throw new NotImplementedException();
        }
    }
}
