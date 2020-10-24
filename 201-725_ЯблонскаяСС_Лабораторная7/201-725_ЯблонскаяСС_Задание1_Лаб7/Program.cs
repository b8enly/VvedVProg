using System;

namespace _201_725_ЯблонскаяСС_Задание1_Лаб7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double pi = 3.14;
            a = double.Parse(Console.ReadLine());
            double n = (a * pi) / 180;
            Console.WriteLine(Math.Round(n, 1));
            Console.ReadKey();
        }
    }
}
