using System;

namespace _201_725_ЯблонскаяСС_Задание5_Лабораторная1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, a1, b1, sum, raz, pro, chas;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            a1 = Math.Abs(a);
            b1 = Math.Abs(b);
            sum = a1 + b1;
            raz = Math.Abs(a1 - b1);
            pro = a1 * b1;
            chas = a1 / b1;
            Console.WriteLine("Summa = " + sum);
            Console.WriteLine("Raznitsa = " + raz);
            Console.WriteLine("Proizvedenie = " + pro);
            Console.WriteLine("Chastnoe = " + chas);
            Console.ReadKey();
        }
    }
}
