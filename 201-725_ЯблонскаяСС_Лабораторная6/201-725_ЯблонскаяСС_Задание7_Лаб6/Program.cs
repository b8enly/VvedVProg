using System;

namespace _201_725_ЯблонскаяСС_Задание7_Лаб6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            A = int.Parse(Console.ReadLine());
            B = A * A; //A^2
            C = B * A; //A^3
            A = B * B; //A^4
            B = A * A; //A^8
            A = B * A; //A^12
            B = A * C; //A^15
            Console.WriteLine(B);
            Console.ReadKey();
        }
    }
}
