using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena.Core
{
    public class Chest : IDamageable
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int HealthMax { get; set; }

        public Chest(string name, int healthMax)
        {
            Name = name;
            Health = healthMax;
            HealthMax = healthMax;
        }

        public int Defense()
        {
            return 0;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public override string ToString()
        {
            return $"{Name}, Health: {Health}, HealthMax: {HealthMax}";
        }
    }
}
