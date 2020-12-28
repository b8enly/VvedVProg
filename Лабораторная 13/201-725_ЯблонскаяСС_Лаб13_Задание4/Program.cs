using System;

namespace _201_725_ЯблонскаяСС_Лаб13_Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            float A = float.Parse(Console.ReadLine());
            Console.Write("Enter the power of the number: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double rez = 0;
            int i;
            Console.WriteLine("The result is: ");
            for (i = 0; i <= N; i++)
            {
                Console.WriteLine(rez = rez + (Math.Pow(A, i)));
            }
            Console.ReadKey();
        }
    }
}
