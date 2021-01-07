using System;

namespace _201_725_ЯблонскаяСС_Лаб16_Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, s;
            Console.Write("Enter the number N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter the first number of array: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number of array: ");
            b = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            s = a + b;
            mass[0] = a;
            mass[1] = b;
            for (int i = 2; i < mass.Length; i++)
            {
                mass[i] = s;
                s *= 2;
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
