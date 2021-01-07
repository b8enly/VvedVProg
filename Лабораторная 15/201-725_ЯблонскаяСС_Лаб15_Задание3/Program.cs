using System;

namespace _201_725_ЯблонскаяСС_Лаб15_Задание3
{
    class Program
    {
        static double S(double r1, double r2)
        {
            double CS = 3.14 * (Math.Pow(r1, 2) - Math.Pow(r2, 2));
            return CS;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                double CS = 0;
                Console.Write("Enter the first outer radius of the circle: ");
                double r1 = double.Parse(Console.ReadLine());
                Console.Write("Enter the second inner radius of the circle: ");
                double r2 = double.Parse(Console.ReadLine());
                Console.Write("The area of the ");
                Console.Write(i);
                Console.Write(" circle is ");
                Console.WriteLine(S(r1, r2));
            }
            Console.ReadKey();
        }
    }
}

