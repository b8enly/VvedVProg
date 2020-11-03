using System;

namespace _201_725_ЯблонскаяСС_Задание5_Лаб2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, x3, y3, a, b, c, st, S, P, pol;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Please enter coordinates of the first point, A");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coordinates of the second point, B");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coordinates of the third point, C");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            st = 2;
            b = Math.Abs(Math.Sqrt(Math.Pow((x3 - x1), st) + Math.Pow((y3 - y1), st)));
            a = Math.Abs(Math.Sqrt(Math.Pow((x3 - x2), st) + Math.Pow((y2 - y3), st)));
            c = Math.Abs(Math.Sqrt(Math.Pow((x2 - x1), st) + Math.Pow((y2 - y1), st)));
            P = a + b + c;
            pol = (a + b + c) / 2;
            S = Math.Abs(Math.Sqrt(pol * (pol - a) * (pol - b) * (pol - c)));
            Console.WriteLine("S = " + Math.Round(S, 1));
            Console.WriteLine("P = " + Math.Round(P, 1));
            Console.ReadKey();
        }
    }
}
