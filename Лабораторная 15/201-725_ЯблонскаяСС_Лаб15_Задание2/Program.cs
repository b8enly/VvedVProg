using System;

namespace _201_725_ЯблонскаяСС_Лаб15_Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sign(double X)
            {
                if (X < 0)
                {
                    X = -1;
                }
                if (X == 0)
                {
                    X = 0;
                }
                if (X > 0)
                {
                    X = 1;
                }
                return X;
            }
            Console.Write("Enter the first number (A): ");
            double A = double.Parse(Console.ReadLine());
            double X = A;
            double X1 = Sign(X);
            Console.Write("Enter the second number (B): ");
            double B = double.Parse(Console.ReadLine());
            X = B;
            double X2 = Sign(X);
            Console.Write("The result is ");
            Console.WriteLine(X1 + X2);
            Console.ReadKey();
        }
    }
}
