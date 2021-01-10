using System;

namespace _201_725_ЯблонскаяСС_Лаб18_Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 0, i2 = 0;
            int max = -2147483647, min = 2147483647;
            Console.Write("Enter the power of the array A: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    i1 = i;
                }
                if (a[i] > max)
                {
                    max = a[i];
                    i2 = i;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (((i > i1)&&(i < i2))||((i < i1)&&(i > i2)))
                {
                    a[i] = 0;
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
