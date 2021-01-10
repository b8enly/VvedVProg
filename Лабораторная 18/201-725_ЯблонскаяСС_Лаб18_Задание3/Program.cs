using System;

namespace _201_725_ЯблонскаяСС_Лаб18_Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the power of the array A: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int min = 2147483647;
            for (int i = 0; i < n; i++)
            {
                if ((a[i] % 2 != 0) && (a[i] < min))
                {
                    min = a[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if ((a[i] % 2 != 0))
                {
                    a[i] += min;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                Console.WriteLine(a[i]);
            }
        }
    }
}
