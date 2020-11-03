using System;

namespace _201_725_ЯблонскаяСС_Задание1_Лаб8
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            a = float.Parse(Console.ReadLine());
            b = a / 1024;
            Console.WriteLine(Math.Round(b, 1));
        }
    }
}
