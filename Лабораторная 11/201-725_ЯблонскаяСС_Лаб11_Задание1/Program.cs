using System;

namespace _201_725_ЯблонскаяСС_Лаб11_Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a != b)
            {
                if (a > b)
                {
                    b = a;
                }
                else a = b;
            }
            else
            {
                a = 0;
                b = 0;
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
