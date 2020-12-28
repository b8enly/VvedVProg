using System;

namespace _201_725_ЯблонскаяСС_Лаб13_Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the price for 1 kg: ");
            double b = double.Parse(Console.ReadLine());
            double a = b / 1000;
            Console.WriteLine();
            Console.Write("The price for 0,1 kg is ");
            Console.WriteLine(a * 100);
            Console.Write("The price for 0,2 kg is ");
            Console.WriteLine(a * 200);
            Console.Write("The price for 0,3 kg is ");
            Console.WriteLine(a * 300);
            Console.Write("The price for 0,4 kg is ");
            Console.WriteLine(a * 400);
            Console.Write("The price for 0,5 kg is ");
            Console.WriteLine(a * 500);
            Console.Write("The price for 0,6 kg is ");
            Console.WriteLine(a * 600);
            Console.Write("The price for 0,7 kg is ");
            Console.WriteLine(a * 700);
            Console.Write("The price for 0,8 kg is ");
            Console.WriteLine(a * 800);
            Console.Write("The price for 0,9 kg is ");
            Console.WriteLine(a * 900);
            Console.Write("The price for 1 kg is ");
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
