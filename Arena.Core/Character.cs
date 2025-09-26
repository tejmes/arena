using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena.Core
{
    public abstract class Character : IDamageable
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int HealthMax { get; set; }
        public int DamageMax { get; set; }
        public int ArmorMax { get; set; }

        protected static readonly Random rnd = new Random();

        public Character(string name, int healthMax, int damageMax, int armorMax)
        {
            Name = name;
            Health = healthMax;
            HealthMax = healthMax;
            DamageMax = damageMax;
            ArmorMax = armorMax;
        }

        public virtual int Attack(IDamageable opponent)
        {
            int attackValue = 0;
            attackValue = rnd.Next(DamageMax + 1);
            attackValue -= opponent.Defense();

            if (attackValue < 0) attackValue = 0;
            opponent.Health -= attackValue;

            return attackValue;
        }

        public int Defense()
        {
            int defenseValue = 0;
            defenseValue = rnd.Next(ArmorMax + 1);

            return defenseValue;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public abstract bool CheckSameSpecies(Character character);

        public override string ToString()
        {
            return $"{Name}, Health: {Health}, HealthMax: {HealthMax}, DamageMax: {DamageMax}, ArmorMax: {ArmorMax}";
        }
    }
}
