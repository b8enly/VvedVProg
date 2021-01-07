using System;

namespace _201_725_ЯблонскаяСС_Лаб15_Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            double PowerA3(double A, double B)
            {
                B = A * A * A;
                return B;
            }
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter the number (A): ");
                double A = double.Parse(Console.ReadLine());
                double B = 0;
                B = PowerA3(A, B);
                Console.Write("The result is: ");
                Console.WriteLine(B);
            }
            Console.ReadKey();
        }
    }
}
