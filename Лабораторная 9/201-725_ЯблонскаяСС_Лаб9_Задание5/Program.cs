using System;

namespace _201_725_ЯблонскаяСС_Лаб9_Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            N /= 100;
            Console.WriteLine(N + 1);
            Console.ReadKey();
        }
    }
}
