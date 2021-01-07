using System;

namespace _201_725_ЯблонскаяСС_Лаб14_Задание6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number: ");
            int N = int.Parse(Console.ReadLine());
            int F1, F2, K;
            F1 = 1;
            F2 = 1;
            K = 2;
            while (N > F2)
            {
                F2 = F1 + F2;
                F1 = F2 - F1;
                K++;
            }
            if (N == F2)
            {
                Console.Write("The answer is: ");
                Console.WriteLine(K);
            }
            else
            {
                Console.WriteLine("Invalid data");
            }
        }
    }
}
