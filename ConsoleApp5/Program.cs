using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    internal class Program
    {
        static double PowNumber(double number, double power)
        {
            switch (power)
            {
                case 0:
                    return 1;
                case 1:
                    return number;
                case 2:
                    return number * number;
                default:
                    return System.Math.Pow(number, power);
            }
        }
        static void Main(string[] args)
        {
            var initNumber = 10;

            var powers = new double[] { -2, -1, 1, 2, 3, 4, 5 };
            var numbersList = new List<double>();

            foreach (var power in powers)
            {
                var poweredNumber = PowNumber(initNumber, power);
                numbersList.Add(poweredNumber);
            }

            foreach (var number in numbersList)
            {
                var isInteger = number == Math.Floor(number);

                if (isInteger)
                {
                    Console.WriteLine(string.Join(" ", number.ToString().ToCharArray()));
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();
        }
    }
}