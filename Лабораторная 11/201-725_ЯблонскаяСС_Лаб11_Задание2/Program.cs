using System;

namespace _201_725_ЯблонскаяСС_Лаб11_Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ((a > b) && (b > c))
            {
                Console.WriteLine(a + b);
            }
            else if ((b > a) && (a > c))
            {
                Console.WriteLine(a + b);
            }
            else if ((c > a) && (a > b))
            {
                Console.WriteLine(a + c);
            }
            else if ((a > c) && (c > b))
            {
                Console.WriteLine(a + c);
            }
            else if ((b > c) && (c > a))
            {
                Console.WriteLine(b + c);
            }
            else Console.WriteLine(b + c);
            Console.ReadKey();
        }
    }
}
