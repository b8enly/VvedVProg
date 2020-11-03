using System;

namespace _201_725_ЯблонскаяСС_Лаб11_Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, x3, y3, a, b, c, d, ab, ac;
            Console.WriteLine("Please enter coordinates of the first point, A");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coordinates of the second point, B");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coordinates of the third point, C");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            a = Math.Abs(x2 - x1);
            b = Math.Abs(y2 - y1);
            c = Math.Abs(x3 - x1);
            d = Math.Abs(y3 - y1);
            ab = Math.Sqrt(a * a + b * b);
            ac = Math.Sqrt(c * c + d * d);
            if (ab > ac)
            {
                Console.WriteLine(ac);
                Console.WriteLine("C (" + x3 + ", " + y3 + ")");
            }
            else
            {
                Console.WriteLine(ab);
                Console.WriteLine("B (" + x2 + ", " + y2 + ")");
            }
        }
    }
}
