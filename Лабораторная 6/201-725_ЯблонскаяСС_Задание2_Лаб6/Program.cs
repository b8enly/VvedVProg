using System;

namespace _201_725_ЯблонскаяСС_Задание2_Лаб6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            a = a + b + c;
            b = a - b - c;
            c = a - b - c;
            a = a - b - c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
