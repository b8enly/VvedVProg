using System;

namespace _201_725_ЯблонскаяСС_Лаб17_Задание2
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
                Console.Write("The {0} number of array is ", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            int k = mass[1] - mass[0];
            for (int i = 1; ((i < n) && (k != 0)); i++)
            {
                if (k != mass[i] - mass[i - 1])
                {
                    k = 0;
                }
            }
            Console.WriteLine("The answer is {0}", k);
            Console.ReadKey();
        }
    }
}
