using System;

namespace _201_275_ЯблонскаяСС_Задание6_Лаб6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            A = int.Parse(Console.ReadLine());
            B = A * A;
            A = B * B;
            B = A * A;
            Console.WriteLine(B);
            Console.ReadKey();
        }
    }
}
