using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 4 +++");
            Console.Write("Введите A и B (через пробел): ");
            string[] st = Console.ReadLine().Split(' ');
            int a = int.Parse(st[0]); int b = int.Parse(st[1]);
            int s = 0; ;
            for (int i = a; i <= b; i++)
            {
                s = s + i * i;
            }
            Console.WriteLine("s = " + s.ToString());
        }
    }
}
