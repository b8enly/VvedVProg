using System;

namespace _201_725_ЯблонскаяСС_Задание3_Лаб8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = Math.Floor(a / b);
            d = a - b * c;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
