using System;

namespace _201_725_ЯблонскаяСС_Лаб17_Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, l;
            int sum = 0;
            Console.Write("Enter the number N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number K: ");
            k = int.Parse(Console.ReadLine());
            Console.Write("Enter the number L: ");
            l = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            if (l > k && l < n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Write the {0} number: ", i);
                    mass[i] = int.Parse(Console.ReadLine());
                }
                for (int i = k - 1; i <= l - 1; i++)
                {
                    sum += mass[i];
                }
                int sr = sum / (l - k + 1);
                Console.WriteLine("Average is: {0}", sr);
            }
            else 
            { 
                Console.WriteLine("Invalid data!"); 
            }
            Console.ReadKey();
        }
    }
}