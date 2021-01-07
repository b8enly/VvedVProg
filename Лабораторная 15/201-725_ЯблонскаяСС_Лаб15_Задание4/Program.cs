using System;

namespace _201_725_ЯблонскаяСС_Лаб15_Задание4
{
    class Program
    {
        static double C(double x, double y)
        {
            if ((x > 0) && (y > 0))
            {
                return 1;
            }
            if ((x > 0) && (y < 0))
            {
                return 4;
            }
            if ((x < 0) && (y > 0))
            {
                return 2;
            }
            if ((x < 0) && (y < 0))
            {
                return 3;
            }
            return x;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            double y = double.Parse(Console.ReadLine());
            double Q = C(x, y);
            Console.WriteLine();
            switch (Q)
            {
                case 1:
                    {
                        Console.WriteLine("The answer is the first (1) quater.");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The answer is the second (2) quater.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("The answer is the third (3) quater.");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("The answer is the fourth (4) quater.");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
