using System;

namespace _201_725_ЯблонскаяСС_Лаб16_Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the power of the array: ");
            int N = int.Parse(Console.ReadLine());
            int[] massive = new int[N];
            for (int i = 1; i <= massive.Length; i++)
            {
                massive[i-1] = 2 * i - 1;
            }
            Console.Write("Array: ");
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write(massive[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}