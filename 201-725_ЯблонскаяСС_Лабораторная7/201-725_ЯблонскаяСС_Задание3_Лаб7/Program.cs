using System;

namespace _201_725_ЯблонскаяСС_Задание3_Лаб7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, a2;
            Console.WriteLine("Enter the variable a (given price)");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the variable x (given weight)");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the variable y (required weight)");   
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            a2 = y * (a / x);
            Console.WriteLine("The price for required weight is " +a2);
            Console.ReadKey();
        }
    }
}
