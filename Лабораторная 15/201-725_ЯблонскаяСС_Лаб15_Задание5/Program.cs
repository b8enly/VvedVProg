using System;

namespace _201_725_ЯблонскаяСС_Лаб15_Задание5
{
    class Program
    {
        static double Fact2(int N)
        {
            double res = 1;
            for (; N > 0; N -= 2)
                res *= N;
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number N: ");
            int N = int.Parse(Console.ReadLine());
            double r = Fact2(N);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
