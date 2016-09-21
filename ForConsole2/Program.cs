using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 2 +++");
            Console.Write("Введите число: ");
            short n = short.Parse(Console.ReadLine());
            double s = 0; ;
            for (short i = 1; i <= n; i++)
            {
                s = s + 1.0 / i;
            }
            Console.WriteLine("S = " + s.ToString());
        }
    }
}
