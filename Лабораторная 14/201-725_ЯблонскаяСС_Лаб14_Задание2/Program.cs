using System;

namespace _201_725_ЯблонскаяСС_Лаб14_Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the segment A: ");
            int A  = int.Parse(Console.ReadLine());
            Console.Write("Enter the length of the segment B: ");
            int B = int.Parse(Console.ReadLine());
            if (A >= B)
            {
                while (A >= B)
                {
                    A = A - B;
                }
                Console.Write("The length of the free segment is: ");
                Console.WriteLine(A);
            }
            else 
            { 
                Console.WriteLine("Invalid Data"); 
            }
            Console.ReadKey();
        }
    }
}
