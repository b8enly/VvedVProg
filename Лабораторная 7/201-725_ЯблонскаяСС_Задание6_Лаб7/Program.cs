using System;
using System.Globalization;

namespace _201_725_ЯблонскаяСС_Задание6_Лаб7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, b1, c1, a2, b2, c2, x, y, delx, dely, del;
            Console.WriteLine("Enter the variable A1 for the equation A1·x + B1·y = C1");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the variable B1 for the equation A1·x + B1·y = C1");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine(); 
            Console.WriteLine("Enter the variable C1 for the equation A1·x + B1·y = C1");
            c1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the variable A2 for the equation A2·x + B2·y = C2");
            a2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the variable B2 for the equation A2·x + B2·y = C2");
            b2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the variable C2 for the equation A2·x + B2·y = C2");
            c2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            del = a1 * b2 - a2 * b1;
            delx = c1 * b2 - c2 * b1;
            dely = a1 * c2 - a2 * c1;

            x = delx / del;
            y = dely / del;

            Console.WriteLine("X is " + x);
            Console.WriteLine("Y is " + y);
            Console.ReadKey();
        }
    }
}
