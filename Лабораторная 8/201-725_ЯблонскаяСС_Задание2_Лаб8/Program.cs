using System;

namespace _201_725_ЯблонскаяСС_Задание2_Лаб8
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = a / b;
            Console.WriteLine(Math.Floor(c));
            Console.ReadKey();
        }
    }
}
