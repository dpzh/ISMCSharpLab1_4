using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task5 - Вычислить значение выражения +++"); Console.WriteLine();
            Console.Write("Введите значения x, y, z (через пробел): ");
            string[] st = Console.ReadLine().Split(' ');
            double x = double.Parse(st[0]); double y = double.Parse(st[1]); double z = double.Parse(st[2]);
            double t = (2 * Math.Cos(x - Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + (z * z) / (3 - z * z / 5));
            Console.WriteLine("t = " + t.ToString());
        }
    }
}
