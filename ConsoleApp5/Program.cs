using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void DoBattle(Hero hero1, Hero hero2)
        {
            Console.WriteLine($"Battle between {hero1.Name} and {hero2.Name} begins!");
            var time = 0d;

            while (true)
            {
                time += 0.01;
                Thread.Sleep(10);

                var attacksOccurred = false;

                foreach (var attacker in new[] { hero1, hero2 })
                {
                    if (attacker.CanAttack(time))
                    {
                        var defender = (attacker == hero1) ? hero2 : hero1;
                        attacker.ProcessAttack(time, defender);
                        attacksOccurred = true;
                    }
                }

                if (attacksOccurred)
                {
                    var hero1IsAlive = !hero1.IsDead();
                    var hero2IsAlive = !hero2.IsDead();

                    if (hero1IsAlive && hero2IsAlive)
                        continue;

                    if (!hero1IsAlive && !hero2IsAlive)
                    {
                        Console.WriteLine("Draw! Both heroes died simultaneously!");
                        return;
                    }

                    var winner = hero1IsAlive == true ? hero1 : hero2;

                    Console.WriteLine($"{winner.Name} wins!"); 
                    return;
                }
            }
        }

        static void Main(string[] args)
        {
            var pudge = new Pudge();
            var slark = new Slark();

            pudge.GetHeroDPS();
            slark.GetHeroDPS();

            DoBattle(pudge, slark);

            Console.ReadLine();
        }
    }
}
