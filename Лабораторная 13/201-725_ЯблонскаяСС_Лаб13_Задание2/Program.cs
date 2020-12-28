using System;

namespace _201_725_ЯблонскаяСС_Лаб13_Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of operations: ");
            int N = int.Parse(Console.ReadLine());
            int i;
            double b = 1;
            for (i = 1; i < N; i++)
            {
                b = b * (1 + 0.1 * i);
            }
            Console.Write("The answer is ");
            Console.Write(b);
            Console.ReadKey();
        }
    }
}
