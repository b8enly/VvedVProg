using System;

namespace _201_725_ЯблонскаяСС_Лаб13_Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            float A = float.Parse(Console.ReadLine());
            Console.Write("Enter the power of the number: ");
            int N = int.Parse(Console.ReadLine());
            float t = 1;
            float res = 0;
            int i;
            for (i = 0; i <= N; i++)
            {
                res += t;
                t *= -A;
            }
            Console.Write("The answer is ");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
