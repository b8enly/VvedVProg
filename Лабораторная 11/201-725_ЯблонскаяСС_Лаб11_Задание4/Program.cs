using System;

namespace _201_725_ЯблонскаяСС_Лаб11_Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter coordinates for the point");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if ((x1 > 0)&&(y1 > 0))
            {
                Console.WriteLine("1");
            }
            else if ((x1 < 0)&&(y1 > 0))
            {
                Console.WriteLine("2");
            }
            else if ((x1 < 0)&&(y1 < 0))
            {
                Console.WriteLine("3");
            }
            else if ((x1 > 0)&&(y1 < 0))
            {
                Console.WriteLine("4");
            }
            Console.ReadKey();
        }
    }
}
