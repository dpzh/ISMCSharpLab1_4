using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task2 - Вычислить значение выражения +++"); Console.WriteLine();
            Console.Write("Введите значения m и n (через пробел) ");
            string[] st = Console.ReadLine().Split(' ');
            double m = double.Parse(st[0]); double n = double.Parse(st[1]);
            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m,3) * n) + n * m + Math.Pow(m,2) - m);
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine("z1 = {0}; z2 = {1}", z1, z2);
        }
    }
}
