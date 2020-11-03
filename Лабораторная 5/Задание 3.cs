using System;
using System.Numerics;

namespace _201_725_ЯблонскаяСС_Задание3_Лабораторная2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            double x1, x2, x3, y1, y2, y3, a, b, c, d;
            Console.WriteLine("Please enter coordinates of the first point, A");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coordinates of the second point, B");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coordinates of the third point, C");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            a = Math.Abs(x3 - x1);
            b = Math.Abs(y3 - y1);
            c = Math.Abs(x2 - x3);
            d = Math.Abs(y2 - y3);
            double ac = Math.Sqrt((a * a) + (b * b));
            double bc = Math.Sqrt((c * c) + (d * d));
            double q = ac * bc;
            Console.WriteLine("The answer is " + q);
            Console.ReadKey();
        }
    }
}
