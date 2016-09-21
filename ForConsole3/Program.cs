using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 3 +++");
            Console.Write("Введите A и N (через пробел): ");
            string[] st = Console.ReadLine().Split(' ');
            float a = float.Parse(st[0]); short n = short.Parse(st[1]);
            float z = a; ;
            for (short i = 2; i <= n; i++)
            {
               z=z*a;
            }
            Console.WriteLine("z = " + z.ToString());
        }
    }
}
