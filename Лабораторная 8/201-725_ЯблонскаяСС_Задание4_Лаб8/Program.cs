using System;
using System.Threading.Tasks.Dataflow;

namespace _201_725_ЯблонскаяСС_Задание4_Лаб8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            if (Math.Abs(a) > 99)
            {
                Console.WriteLine("Invalid data format");
            }
            else
            {
                b = a % 10;
                c = a / 10;
                d = b * 10 + c;
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
