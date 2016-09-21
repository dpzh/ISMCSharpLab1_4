using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task Pi - 2 +++");
            Console.Write("Введите количество итераций: ");
            int n = int.Parse(Console.ReadLine());
            decimal x = 1m;
            decimal c = 1m;
            for (int i = 1; i <= n; i++)
            {
                x = x * (c * (c + 2) / ((c+1) * (c+1)));
                c += 2;
            }
            decimal pi = 2/x;
            Console.WriteLine("PI = " + pi.ToString());
        }
    }
}
