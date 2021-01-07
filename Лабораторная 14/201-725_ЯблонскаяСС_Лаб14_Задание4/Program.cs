using System;

namespace _201_725_ЯблонскаяСС_Лаб14_Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = 0;
            double C = 1000;
            Console.Write("Enter the interest from 0 to 25%: ");
            double p = double.Parse(Console.ReadLine());
            p /= 100;
            while (C <= 1100)
            {
                C += (p * C);
                K += 1;
            }
            Console.Write("Total amount of money: ");
            Console.WriteLine(C);
            Console.Write("The number of months: ");
            Console.WriteLine(K);
            Console.ReadKey();
        }
    }
}