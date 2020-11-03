using System;

namespace _201_725_ЯблонскаяСС_Лаб10_Задание6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");
            Console.ReadKey();
        }
    }
}
