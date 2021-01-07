using System;

namespace _201_725_ЯблонскаяСС_Лаб14_Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            int GCD;
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine());
            while ((a != 0)&&(b != 0))
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b = b % a;
                }
            }
            GCD = a + b;
            Console.Write("The GCD (greatest common divisor) is: ");
            Console.WriteLine(GCD);
            Console.ReadKey();
        }
    }
}