using System;

namespace _201_725_ЯблонскаяСС_Задание5_Лаб12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year: ");
            int x = int.Parse(Console.ReadLine());
            if (x < 1984)
            {
                Console.WriteLine("Ivalid Data");
            }
            else
            {
                int color = ((x - 1984) % 60 / 12);
                Console.WriteLine();
                Console.Write("The year of the ");
                switch (color)
                {
                    case 0:
                        Console.Write("green ");
                        break;
                    case 1:
                        Console.Write("red ");
                        break;
                    case 2:
                        Console.Write("yellow ");
                        break;
                    case 3:
                        Console.Write("white ");
                        break;
                    case 4:
                        Console.Write("black ");
                        break;
                }
                int animal = (x - 1984) % 12;
                switch (animal)
                {
                    case 0:
                        Console.Write("rat");
                        break;
                    case 1:
                        Console.Write("cow");
                        break;
                    case 2:
                        Console.Write("tiger");
                        break;
                    case 3:
                        Console.Write("rabbit");
                        break;
                    case 4:
                        Console.Write("dragon");
                        break;
                    case 5:
                        Console.Write("snake");
                        break;
                    case 6:
                        Console.Write("horse");
                        break;
                    case 7:
                        Console.Write("sheep");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
