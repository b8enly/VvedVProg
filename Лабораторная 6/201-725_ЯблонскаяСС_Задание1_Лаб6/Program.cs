using System;

namespace _201_725_ЯблонскаяСС_Задание1_Лаб6
{
    class Program
    {
        static void Main(string[] args)
        { 
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
        
