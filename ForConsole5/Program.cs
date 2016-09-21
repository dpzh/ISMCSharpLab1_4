using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Task 5 +++");
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            double s = 0; ;
            double f;
            for (int i = 1; i <= n; i++)
            {
                f = 1;
                for (int j=1;j<=i;j++)
                {
                    f = f * j;
                }
                s = s + f;
                //Console.WriteLine("f = " + f.ToString());
            }
            Console.WriteLine("s = " + s.ToString());
        }
    }
}
