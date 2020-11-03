using System;

namespace _201_725_ЯблонскаяСС_Лаб9_Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int a = k - (7 * (k / 7)) - 1;
            Console.WriteLine(a + n);
            Console.ReadKey();
        }
    }
}