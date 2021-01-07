using System;

namespace _201_725_ЯблонскаяСС_Лаб14_Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number (A): ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number (B): ");
            int B = int.Parse(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
