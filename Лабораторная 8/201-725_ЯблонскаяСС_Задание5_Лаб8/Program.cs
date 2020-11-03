using System;

namespace _201_725_ЯблонскаяСС_Задание5_Лаб8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            if (Math.Abs(a) > 999)
            {
                Console.WriteLine("Ivalid data format");
            }
            else
            {
                d = a / 100;
                b = a - d * 100;
                c = b * 10 + d;
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
