using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task Pi - 4 +++");
            Console.Write("Введите количество итераций: ");
            int n = int.Parse(Console.ReadLine());
            double pi = 1;
            int z = 3;
            for (int i = 1; i <= n; i++)
            {
                pi = pi + (1.0 / z) * (Math.Pow(-1,i));
                z = Math.Abs(z) + 2;
            }
            pi = pi * 4;
            Console.WriteLine("PI = " + pi.ToString());
        }
    }
}
