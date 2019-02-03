using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a*x^2 + b*x + c = 0 ");
            Console.WriteLine("\nInput a:");
            Double a = (double) Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInput b");
            Double b = (double) Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInput c");
            Double c = (double) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n"+a+"*x^2 + "+b+"*x + "+c+" = 0 ");

            Double d = (b * b - 4 * a * c);
            Console.WriteLine("\nD = "+d);
            if (d >= 0)
            {
                double d1 = (Math.Sqrt(d));
                double x1 = (-b + d1) / (2 * a);
                double x2 = (-b - d1) / (2 * a);
                Console.WriteLine("\nx1 = " + x1);
                Console.WriteLine("\nx2 = " + x2);
            }
            if (d == 0)
            {
                double x1 = (-b) / (2 * a);
                Console.WriteLine("\nx1 = x2 = " + x1);
            }
            //double d1 = (double)Convert.ToDouble(Math.Sqrt(d));

            if (d < 0)
            {
                double d1 = (Math.Sqrt(d*-1));   //извлечь квадратный корень из отрицательного числа
    
                double xRe = (-b) / (2 * a);
                double xIm = d1 / (2 * a);
                Console.WriteLine("\nx1 = " + xRe + " + i" + xIm);
                Console.WriteLine("\nx2 = " + xRe + " - i" + xIm);
            }
            
            Console.ReadKey();

         
        }
    }
}
