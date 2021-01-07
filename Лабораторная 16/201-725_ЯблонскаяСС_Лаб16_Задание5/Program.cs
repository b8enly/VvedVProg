using System;

namespace _201_725_ЯблонскаяСС_Лаб16_Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number N: ");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Write the {0} number: ", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i += 2)
            {
                Console.WriteLine(mass[i]);
            }
            if (n % 2 != 0)
                for (int i = n - 1; i >= 0; i -= 2)
                {
                    Console.WriteLine(mass[i]);
                }
            else
                for (int i = n - 2; i >= 0; i -= 2)
                {
                    Console.WriteLine(mass[i]);
                }
            Console.ReadKey();
        }
    }
}
