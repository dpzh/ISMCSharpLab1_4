using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task3 - Вычислить значение выражения +++"); Console.WriteLine();
            Console.Write("Введите значения x, a, b (через пробел): ");
            string[] st = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(st[0]);
            double a = Convert.ToDouble(st[1]); double b = Convert.ToDouble(st[2]);
            double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + 0.01 * (x - b);
            Console.WriteLine("y = " + y.ToString());
        }
    }
}
