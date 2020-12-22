using System;

namespace _201_725_ЯблонскаяСС_Задание2_Лаб12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; char c;
            Console.Write("Enter the direction ");
            Console.Write("(S for South, W for West, E for East, N for North): ");
            c = char.Parse(Console.ReadLine());
            Console.Write("Enter the number of the command: ");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    switch (c)
                    {
                        case 'S':
                            Console.WriteLine("East");
                            return;

                        case 'N':
                            Console.WriteLine("West");
                            return;

                        case 'W':
                            Console.WriteLine("South");
                            return;

                        case 'E':
                            Console.WriteLine("North");
                            return;
                    }
                    break;
            }
            switch (n)
            {
                case -1:
                    switch (c)
                    {
                        case 'S':
                            Console.WriteLine("West");
                            return;

                        case 'N':
                            Console.WriteLine("East");
                            return;

                        case 'W':
                            Console.WriteLine("North");
                            return;

                        case 'E':
                            Console.WriteLine("South");
                            return;
                    }
                    break;
            }
            switch (n)
            {
                case 0:
                    switch (c)
                    {
                        case 'S':
                            Console.WriteLine("South");
                            return;

                        case 'N':
                            Console.WriteLine("North");
                            return;

                        case 'W':
                            Console.WriteLine("West");
                            return;

                        case 'E':
                            Console.WriteLine("East");
                            return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid data");
                break;
            }
            Console.ReadKey();
        }
    }
}
