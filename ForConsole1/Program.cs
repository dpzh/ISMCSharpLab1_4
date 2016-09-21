using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 1 +++");
            Console.Write("Введите два числа (через пробел): ");
            string [] st = Console.ReadLine().Split(' ');
            short a = short.Parse(st[0]); short b = short.Parse(st[1]);
            int d = 1; ;
            for (short i=a;i<=b;i++)
            {
                d = d * i;
            }
            Console.WriteLine("d = " + d.ToString());
        }
    }
}
