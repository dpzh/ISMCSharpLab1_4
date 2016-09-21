using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task4 - Вычислить значение выражения +++"); Console.WriteLine();
            Console.Write("Введите значения x, y, z (через пробел): ");
            string[] st = Console.ReadLine().Split(' ');
            double x = double.Parse(st[0]); double y = double.Parse(st[1]); double z = double.Parse(st[2]);
            double f = (Math.Pow((y + Math.Pow(x - 1, 1.0 / 3)), 1.0 / 4)) / (Math.Abs(x - y) * (Math.Sin(z) * Math.Sin(z) + Math.Tan(z)));
            Console.WriteLine("f = " + f.ToString());
        }
    }
}
