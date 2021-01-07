using System;

namespace _201_725_ЯблонскаяСС_Лаб14_Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int K = 0;
            Console.Write("Enter the number N: ");
            int N = int.Parse(Console.ReadLine());
            while (A <= N)
            {
                K += 1;
                A += K;
            }
            Console.Write("The amount (A) is: ");
            Console.WriteLine(A);
            Console.Write("The minimum number (K) is: ");
            Console.WriteLine(K);
            Console.ReadKey();
        }
    }
}