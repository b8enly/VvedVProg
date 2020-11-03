using System;

namespace _201_725_ЯблонскаяСС_Задание3_Лабораторная1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double s;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            s = (a + b) / 2.00;
            Console.WriteLine("Srednee arifmeticheskoe = " + s);
            Console.ReadKey();
        }
    }
}
