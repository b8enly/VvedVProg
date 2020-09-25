using System;

namespace _201_725_ЯблонскаяСС_Задание4_Лабораторная2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, a, b, S, P;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Please, enter coordinates for the first point");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter coordinates for the second point");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            a = Math.Abs(x2 - x1);
            b = Math.Abs(y2 - y1);
            P = (a + b) * 2;
            S = a * b;
            Console.WriteLine("S is " + S);
            Console.WriteLine("P is " + P);
            Console.ReadKey();
        }
    }
}
