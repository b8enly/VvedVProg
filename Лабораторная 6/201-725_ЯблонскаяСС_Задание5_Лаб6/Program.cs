using System;

namespace _201_725_ЯблонскаяСС_Задание5_Лаб6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, x;
            x = double.Parse(Console.ReadLine()); //y = 4(x−3)6 − 7(x−3)3 + 2
            a = 4 * Math.Pow((x - 3), 6) - 7 * Math.Pow((x - 3), 3) + 2;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
