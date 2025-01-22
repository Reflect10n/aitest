using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Pudge : Hero
    {
        public override double MoveSpeed { get; set; }
        public override double AttackDamage { get; set; }
        public override double Armor { get; set; }
        public override double AttackSpeed { get; set; }
        public override double HealthPoint { get; set; }
        public override double ManaPoint { get; set; }

        public Pudge()
        {
            Name = "Pudge";
            MoveSpeed = 420;
            AttackDamage = 85.2;
            Armor = 2.1;
            AttackSpeed = 1.2;
            HealthPoint = 600;
            ManaPoint = 200;
        }
    }
}
