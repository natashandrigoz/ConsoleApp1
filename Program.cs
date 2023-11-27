using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Коэффициенты квадратного уравнения:");
            Console.Write("a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c= ");
            double c = Convert.ToDouble(Console.ReadLine());
            //вычисление дискриминанта
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                Console.WriteLine("Уравнение имеет 2 корня");
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"x1= {x1:f2}\tx2= {x2:f2}");
            }
            if (d == 0)
            {
                Console.WriteLine("Уравнение имеет 1 корень");
                double x1 = (-b) / (2 * a);
                Console.WriteLine($"x1= {x1:f2}");
            }
            if (d < 0)
            {
                Console.WriteLine("Уравнение не имеет корней");
            }
            Console.Read();
        }
    }
}
