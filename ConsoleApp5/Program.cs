using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args) {
            int a = 10;
            int b = 10;
            double ac = System.Math.Pow(a, 2);
            double bc = System.Math.Pow(b, 2);
            char[] c = a.ToString().ToCharArray();
            foreach (var  c2 in c) {
                Console.Write(c2);
                Console.Write(' ');
                }
        }
    }
}
