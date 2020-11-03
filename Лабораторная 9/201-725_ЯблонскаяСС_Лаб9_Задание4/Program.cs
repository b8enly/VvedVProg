using System;

namespace _201_725_ЯблонскаяСС_Лаб9_Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int kol = (a * b) / (c * c);
            int space = ((a * b) - ((c * c) * ((a * b) / (c * c))));
            Console.WriteLine("Max availible amount of squares = " + kol);
            Console.WriteLine("Left space = " + space);
            Console.ReadKey();
        }
    }
}
