using System;

namespace _201_725_ЯблонскаяСС_Лаб13_Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int rez = 0;
            Console.Write("Enter the number: ");
            int N = int.Parse(Console.ReadLine());
            for (i = 1; i <= N; i++)
            {
                Console.WriteLine(rez += 2 * i - 1);
            }
            Console.ReadKey();
        }
    }
}
