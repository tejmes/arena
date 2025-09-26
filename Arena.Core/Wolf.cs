using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena.Core
{
    public class Wolf : Character
    {
        public Wolf(string name, int healthMax, int damageMax, int armorMax) : base(name, healthMax, damageMax, armorMax)
        {
        }

        public override bool CheckSameSpecies(Character character)
        {
            return character is not Wolf;
        }
    }
}
