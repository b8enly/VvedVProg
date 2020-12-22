using System;

namespace _201_725_ЯблонскаяСС_Задание3_Лаб12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if ((a > 40) || (a < 10))
            {
                Console.WriteLine("Invalid Data");
            }
            else
            {
                int b = a / 10;
                int c = a % 10;
                if (b == 1)
                {
                    switch (c)
                    {
                        case 0:
                            Console.Write("ten ");
                            break;
                        case 1:
                            Console.Write("eleven ");
                            break;
                        case 2:
                            Console.Write("twelve ");
                            break;
                        case 3:
                            Console.Write("thirteen ");
                            break;
                        case 4:
                            Console.Write("fourteen ");
                            break;
                        case 5:
                            Console.Write("fifteen ");
                            break;
                        case 6:
                            Console.Write("sixteen ");
                            break;
                        case 7:
                            Console.Write("seventeen ");
                            break;
                        case 8:
                            Console.Write("eighteen ");
                            break;
                        case 9:
                            Console.Write("nineteen ");
                            break;
                    }
                }
                else
                {
                    switch (b)
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
                    }
                    switch (c)
                    {
                        case 1:
                            Console.Write("one ");
                            break;
                        case 2:
                            Console.Write("two ");
                            break;
                        case 3:
                            Console.Write("three ");
                            break;
                        case 4:
                            Console.Write("four ");
                            break;
                        case 5:
                            Console.Write("five ");
                            break;
                        case 6:
                            Console.Write("six ");
                            break;
                        case 7:
                            Console.Write("seven ");
                            break;
                        case 8:
                            Console.Write("eight ");
                            break;
                        case 9:
                            Console.Write("nine ");
                            break;
                    }
                }
                Console.Write("training tasks");
            }
            Console.ReadKey();
        }
    }
}
