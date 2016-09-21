using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task Pi - 1 +++");
            Console.Write("Введите количество итераций: ");
            int n = int.Parse(Console.ReadLine());
            decimal x = (decimal) Math.Sqrt(0.5);

            
            decimal pi = 2 / x;
            Console.WriteLine("PI = " + pi.ToString());
        }
    }
}
