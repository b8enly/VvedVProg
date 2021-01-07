using System;

namespace _201_725_ЯблонскаяСС_Лаб16_Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number N (power of the array): ");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Write the {0} number: ", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            int p = n / 2;
            Console.Write("The answer is: ");
            for (int i = 0; i < p; i++)
            {
                Console.Write(mass[i] + " ");
                Console.Write(mass[n - i - 1] + " ");
            }
            if (p != 0)
            {
                Console.Write(mass[p]);
            }
            Console.ReadKey();
        }
    }
}
