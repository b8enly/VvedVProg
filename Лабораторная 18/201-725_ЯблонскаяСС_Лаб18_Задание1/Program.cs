using System;

namespace _201_725_ЯблонскаяСС_Лаб18_Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the power of the arrays A and B: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("B[{0}] = ", i);
                b[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                int t = a[i];
                a[i] = b[i];
                b[i] = t;
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("B[{0}] = ", i);
                Console.WriteLine(b[i]);
            }
            Console.ReadKey();
        }
    }
}
