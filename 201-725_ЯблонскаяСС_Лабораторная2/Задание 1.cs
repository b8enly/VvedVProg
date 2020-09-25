using System;
namespace _201_725_ЯблонскаяСС_Задание1_Лабораторная2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, a, b;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Please enter coordinates of the first point, A");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coordinates of the second point, B");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            a = Math.Abs(x2 - x1);
            b = Math.Abs(y2 - y1);
            double d = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("The answer is " + d);
            Console.ReadKey();
        }
    }
}
