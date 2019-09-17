using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Melee:Character
    {
        private int abilityPoints;

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
                    abilityPoints = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Value should be greater than 0 and less than or equal to 10");
                }
            }
        }




    }
}
