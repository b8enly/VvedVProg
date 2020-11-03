using System;

namespace _201_725_ЯблонскаяСС_Задание5_Лаб7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;
            Console.WriteLine("Enter the variable A for the equation A*X - B = 0");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the variable B for the equation A*X - B = 0");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (A == 0)
            {
                Console.WriteLine("Ivalid data format");
            }
            else
            {
                X = B / A;
                Console.WriteLine(X);
            }
            Console.ReadKey();
        }
    }
}
