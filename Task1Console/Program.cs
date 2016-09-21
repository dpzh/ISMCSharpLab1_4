using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task1 - Периметр и площадь прямоугольника +++"); Console.WriteLine();
            Console.Write("Введите 2 стороны прямоугольника (целые числа через пробел): ");
            string[] st = Console.ReadLine().Split(' ');
            int a = int.Parse(st[0]); int b = int.Parse(st[1]);
            int p = 2 * (a + b);
            int s = a * b;
            Console.WriteLine("Периметр прямоугольника = " + p);
            Console.WriteLine("Площадь прямоугольника  = " + s);
        }
    }
}
