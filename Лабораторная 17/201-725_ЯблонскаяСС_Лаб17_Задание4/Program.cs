using System;

namespace _201_725_ЯблонскаяСС_Лаб17_Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, max = -2147483647;
            int t = -1; 
            Console.Write("Enter the power of the array N: ");
            N = int.Parse(Console.ReadLine());
            int[] mass = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("A[{0}] = ", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < N - 1; i++)
            {
                if ((mass[i] > mass[i - 1]) && (mass[i] > mass[i + 1]))
                {
                    t = i;
                    max = mass[i];
                }
            }
            if (t > -1)
            {
                Console.WriteLine("Number of the last local maximum is: {0} ", t);
            }
            else
            {
                Console.WriteLine("There is no local maximum");
            }
            Console.ReadKey();
        }
    }
}
