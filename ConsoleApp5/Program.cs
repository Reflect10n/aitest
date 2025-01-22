using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double epsilon = 1e-10;
            var initNumber = 10;

            var powers = new double[] { -2, -1, 1, 2, 3, 4, 5 };
            var numbersList = powers.Select(power => Math.Pow(initNumber, power)).ToList();

            foreach (var number in numbersList)
            {
                var isInteger = Math.Abs(number - Math.Round(number)) < epsilon;

                if (isInteger)
                {
                    var roundedNumber = (int)Math.Round(number);
                    Console.WriteLine(string.Join(" ", roundedNumber.ToString().ToCharArray()));
                }
                else
                    Console.WriteLine(number);
            }
        }
    }
}