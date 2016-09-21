using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadEquationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++ Quadratic Equation +++");
            Console.Write("Enter the coefficients (by space): ");
            string [] st = Console.ReadLine().Split(' ');
            float a = float.Parse(st[0]); float b = float.Parse(st[1]); float c = float.Parse(st[2]);
            float D = b * b - 4 * a * c;
            Console.WriteLine("D = " + D);
            float x1, x2;
            if (D>0)
            {
                x1 = (float) (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (float)(-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
            else if (D==0)
                 {
                    x1 = (-b) / (2 * a);
                    Console.WriteLine("x = " + x1);
                 }
                 else
                 {
                    Console.WriteLine("Solution does not exist");
                 }
        }
    }
}
