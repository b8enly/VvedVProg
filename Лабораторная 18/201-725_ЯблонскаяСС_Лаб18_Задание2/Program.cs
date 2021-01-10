using System;

namespace _201_725_ЯблонскаяСС_Лаб18_Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the power of the array: ");
            int n = int.Parse(Console.ReadLine());
            float[] a = new float[n];
            float[] b = new float[n];
            float sr = 0; float sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                a[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                sr = 0;
                sum = 0;
                b[i] = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum += a[j];
                    sr++;
                }
                b[i] = sum / sr;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("B[{0}] = ", i);
                Console.WriteLine(b[i]);
            }
        }
    }
}
