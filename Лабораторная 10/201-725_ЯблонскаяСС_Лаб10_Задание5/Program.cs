using System;

namespace _201_725_ЯблонскаяСС_Лаб10_Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int n = int.Parse(Console.ReadLine());
            a = n / 1000;
            b = (n / 100) % 10;
            c = (n / 10) % 10;
            d = n % 10;
            if ((a == d) && (b == c))
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
            Console.ReadKey();
        }
    }
}
