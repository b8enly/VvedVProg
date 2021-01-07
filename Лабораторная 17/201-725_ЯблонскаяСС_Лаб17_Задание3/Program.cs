using System;

namespace _201_725_ЯблонскаяСС_Лаб17_Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the power of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            int min = 2147483647;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the number a[{0}] = ", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++) 
            {
                if (i % 2 == 0)
                {
                    min = mass[i];
                }
            }
            Console.WriteLine("Minimum number is = {0}", min);
            Console.ReadKey();
        }
    }
}

