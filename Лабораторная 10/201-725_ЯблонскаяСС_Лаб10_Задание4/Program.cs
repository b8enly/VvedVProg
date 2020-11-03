using System;

namespace _201_725_ЯблонскаяСС_Лаб10_Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if ((((a / 100) < ((a / 10) % 10)) && (((a / 10) % 10) < (a % 10)))|| (((a / 100) > ((a / 10) % 10)) && (((a / 10) % 10) > (a % 10))))
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
