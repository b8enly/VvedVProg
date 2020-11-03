using System;

namespace _201_725_ЯблонскаяСС_Лаб11_Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if ((a > 0)&&(a % 2 == 0))
            {
                Console.WriteLine("Positive even number");
            }
            else if ((a < 0)&&(a % 2 == 0))
            {
                Console.WriteLine("Negative even number");
            }
            else if ((a > 0)&&(a % 2 != 0))
            {
                Console.WriteLine("Positive odd number");
            }
            else if ((a < 0)&&(a % 2 != 0))
            {
                Console.WriteLine("Negative odd number");
            }
            else if (a == 0)
            {
                Console.WriteLine("Number zero");
            }
            Console.ReadKey();
        }
    }
}
