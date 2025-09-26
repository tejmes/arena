using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena.Core
{
    public class Sword
    {
        public int DamageMax {  get; set; }

        public Sword(int damageMax)
        {
            DamageMax = damageMax;
        }
    }
}
