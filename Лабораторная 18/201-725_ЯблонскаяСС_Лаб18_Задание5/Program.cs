using System;

namespace _201_725_ЯблонскаяСС_Лаб18_Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the power of the array A: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int t;
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                if (a[i - 1] > a[i])
                {
                    t = a[i - 1];
                    a[i - 1] = a[i];
                    a[i] = t;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}