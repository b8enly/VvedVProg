using System;

namespace _201_725_ЯблонскаяСС_Задание4_Лаб12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("Enter the number ");
            int x = int.Parse(Console.ReadLine());
            if ((x < 100) || (x > 999))
                Console.WriteLine("Number is out of the range");
            else
            {
                a = x / 100;
                switch (a)
                {
                    case 1:
                        Console.Write("One hundred ");
                        break;
                    case 2:
                        Console.Write("Two hundred ");
                        break;
                    case 3:
                        Console.Write("Three hundred ");
                        break;
                    case 4:
                        Console.Write("Four hundred ");
                        break;
                    case 5:
                        Console.Write("Five hundred ");
                        break;
                    case 6:
                        Console.Write("Six hundred ");
                        break;
                    case 7:
                        Console.Write("Seven hundred ");
                        break;
                    case 8:
                        Console.Write("Eight hundred ");
                        break;
                    case 9:
                        Console.Write("Nine hundred ");
                        break;
                }
                b = x % 100;
                if ((b > 9) && (b < 20))
                {
                    switch (b)
                    {
                        case 10:
                            Console.Write("and ten ");
                            return;
                        case 11:
                            Console.Write("and eleven ");
                            return;
                        case 12:
                            Console.Write("and twelve ");
                            return;
                        case 13:
                            Console.Write("and thirteen ");
                            return;
                        case 14:
                            Console.Write("and fourteen ");
                            return;
                        case 15:
                            Console.Write("and fifteen ");
                            return;
                        case 16:
                            Console.Write("and sixteen ");
                            return;
                        case 17:
                            Console.Write("and seventeen ");
                            return;
                        case 18:
                            Console.Write("and eighteen ");
                            return;
                        case 19:
                            Console.Write("and nineteen ");
                            return;
                    }
                }
                c = (x / 10) % 10;
                switch (c)
                {
                    case 2:
                        Console.Write("twenty ");
                        break;
                    case 3:
                        Console.Write("thirty ");
                        break;
                    case 4:
                        Console.Write("fourty ");
                        break;
                    case 5:
                        Console.Write("fifty ");
                        break;
                    case 6:
                        Console.Write("sixty ");
                        break;
                    case 7:
                        Console.Write("seventy ");
                        break;
                    case 8:
                        Console.Write("eighty ");
                        break;
                    case 9:
                        Console.Write("ninety ");
                        break;
                }
                d = x % 10;
                switch (d)
                {
                    case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}