using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Hero
    {
        public abstract string Name { get; set; }
        public abstract double MoveSpeed { get; set; }
        public abstract double AttackDamage { get; set; }
        public abstract double Armor { get; set; }
        public abstract double AttackSpeed { get; set; }
        public virtual int ViewDistance { get; set; } = 1800;


        public abstract double HealthPoint { get; set; }


        public abstract double ManaPoint { get; set; }


        public double TimeToNextAttack { get; private set; }

        public bool CanAttack(double currentTime) => currentTime >= TimeToNextAttack;

        public void ProcessAttack(double currentTime, Hero target)
        {
            DoDamage(target);
            TimeToNextAttack = currentTime + AttackSpeed;
        }

        public virtual void TakeDamage(double damage, Hero hero)
        {
            var totalDamage = damage - damage * Armor / 100;
            HealthPoint -= totalDamage;
            Console.WriteLine($"Hero {this.Name} took {totalDamage} damage from {hero.Name}. Remainng {this.Name} HP: {HealthPoint}");
        }

        public virtual void GetHeroDPS()
        {
            var dps = AttackDamage * (1 / AttackSpeed);
            Console.WriteLine($"Hero's {this.Name} dps: {dps}");
        }

        public virtual void DoDamage(Hero hero)
        {
            Console.WriteLine($"Hero {this.Name} do {AttackDamage} damage to {hero.Name}");
            hero.TakeDamage(AttackDamage, this);
        }

        public virtual bool IsDead()
        {
            return HealthPoint <= 0;
        }
    }
}
