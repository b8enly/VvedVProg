using System;

namespace _201_725_ЯблонскаяСС_Лаб16_Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, d;
            Console.Write("Enter N (the power of the array): ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter the first number A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the denominator D: ");
            d = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            mass[0] = a;
            for (int i = 1; i < mass.Length; i++)
            {
                mass[i] = mass[i - 1] * d;
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
