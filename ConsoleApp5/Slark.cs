using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Slark: Hero
    {
        public Slark()
        {
            Name = "Slark";
            MoveSpeed = 500;
            AttackDamage = 67.3;
            Armor = 7.23;
            AttackSpeed = 0.87;
            HealthPoint = 500;
            ManaPoint = 200;
        }

        public override void DoDamage(Hero hero)
        {
            base.DoDamage(hero);
            AttackDamage += 1;
        }

        public override string Name { get; protected set; }
        public override double MoveSpeed { get; set; }
        public override double AttackDamage { get; set; }
        public override double Armor { get; set; }
        public override double AttackSpeed { get; set; }
        public override double HealthPoint { get; set; }
        public override double ManaPoint { get; set; }
    }
}
