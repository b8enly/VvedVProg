using System;

namespace _201_725_ЯблонскаяСС_Задание2_Лабораторная1
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, L;
            double p = 3.14;
            d = double.Parse(Console.ReadLine());
            L = p * d;
            Console.WriteLine("L = " + L);
            Console.ReadKey();
        }
    }
}
