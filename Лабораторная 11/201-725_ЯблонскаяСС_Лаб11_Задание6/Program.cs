using System;

namespace _201_725_ЯблонскаяСС_Лаб11_Задание6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if ((a < 10) && (a % 2 == 0))
            {
                Console.WriteLine("One digit even number");
            }
            else if ((a > 9) && (a < 100) && (a % 2 == 0))
            {
                Console.WriteLine("Two digit even number");
            }
            else if ((a > 99)&&(a % 2 == 0))
            {
                Console.WriteLine("Three digit even number");
            }
            else if ((a < 10) && (a % 2 != 0))
            {
                Console.WriteLine("One digit odd number");
            }
            else if ((a > 9)&&(a < 99) && (a % 2 != 0))
            {
                Console.WriteLine("Two digit odd number");
            }
            else if ((a > 99) && (a % 2 != 0))
            {
                Console.WriteLine("Three digit odd number");
            }
            Console.ReadKey();
        }
    }
}

