using System;

namespace _201_725_ЯблонскаяСС_Лаб10_Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            if ((A % 2 == 0) && (A > 9) && (A < 100))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();
        }
    }
}
