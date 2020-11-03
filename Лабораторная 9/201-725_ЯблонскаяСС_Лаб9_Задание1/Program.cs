using System;

namespace _201_725_ЯблонскаяСС_Лаб9_Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int a = N / 60;
            int c = N - 60 * a;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
