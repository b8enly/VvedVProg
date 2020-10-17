using System;

namespace _201_725_ЯблонскаяСС_Задание3_Лаб6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            c = a + b + c;
            b = c - a - b;
            a = c - a - b;
            c = c - a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
