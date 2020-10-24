using System;
using System.Runtime.CompilerServices;

namespace _201_725_ЯблонскаяСС_Задание4_Лаб7
{
    class Program
    {
        static void Main(string[] args)
        {
            int V1, V2, S, T, S1;
            Console.WriteLine("Enter the variable V1, the speed of the first car");
            V1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the variable V2, the speed of the second car");
            V2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the variable S, the given distance between the cars");
            S = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the variable T, the given time");
            T = int.Parse(Console.ReadLine());
            Console.WriteLine();
            S1 = (V1 + V2) * T + S;
            Console.WriteLine(S1);
            Console.ReadKey();
        }
    }
}
