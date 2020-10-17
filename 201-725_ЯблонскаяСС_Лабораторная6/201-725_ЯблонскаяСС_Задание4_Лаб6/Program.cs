using System;


namespace _201_725_ЯблонскаяСС_Задание4_Лаб6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a;
            x = double.Parse(Console.ReadLine());
            a = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
