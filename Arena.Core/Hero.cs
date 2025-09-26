using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena.Core
{
    public class Hero : Character
    {
        public Sword? Sword {  get; set; }

        public Hero(string name, int healthMax, int damageMax, int armorMax) : base(name, healthMax, damageMax, armorMax)
        {
        }

        public Hero(string name, int healthMax, int damageMax, int armorMax, Sword sword) : base(name, healthMax, damageMax, armorMax)
        {
            Sword = sword;
        }

        public override int Attack(IDamageable opponent)
        {
            int damageMax = (Sword != null) ? Sword.DamageMax : this.DamageMax;

            int attackValue = rnd.Next(damageMax + 1);
            attackValue -= opponent.Defense();

            if (attackValue < 0) attackValue = 0;
            opponent.Health -= attackValue;

            return attackValue;
        }

        public override bool CheckSameSpecies(Character character)
        {
            return true;
        }
    }
}
