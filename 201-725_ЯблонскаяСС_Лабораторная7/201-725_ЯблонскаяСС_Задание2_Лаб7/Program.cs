using System;

namespace _201_725_ЯблонскаяСС_Задание2_Лаб7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, pi, n;
            a = double.Parse(Console.ReadLine());
            pi = 3.14;
            n = (a * 180) / pi;
            Console.WriteLine(Math.Round(n, 1));
            Console.ReadKey();
        }
    }
}
