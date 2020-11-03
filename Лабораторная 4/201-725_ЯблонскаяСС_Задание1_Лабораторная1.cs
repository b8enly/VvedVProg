using System;

namespace _201_725_ЯблонскаяСС_Задание1_Лабораторная1_ВВП
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s, p;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            s = a * b;
            p = 2 * (a + b);
            Console.WriteLine("ploshad' = " + s);
            Console.WriteLine("perimetr = " + p);
            Console.ReadKey();
        }
    }
}
