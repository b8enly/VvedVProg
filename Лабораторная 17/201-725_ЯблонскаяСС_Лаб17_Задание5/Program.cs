using System;

namespace _201_725_ЯблонскаяСС_Лаб17_Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.Write("Enter the power of the array N: ");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Number a[{0}] of the array = ", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if ((mass[i] == mass[j]) && (i != j))
                    {
                        a = i;
                        b = j;
                    }
                }
            }
            if (a == 0 && b == 0)
            {
                Console.WriteLine("There is no same values in the array");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("The numbers of the same values are {0}, {1}", b, a);
                }
                else
                {
                    Console.WriteLine("The numbers of the same values are {0}, {1}", a, b);
                }
            }
            Console.ReadKey();
        }
    }
}
