using System;

namespace _201_725_ЯблонскаяСС_Задание1_Лаб12_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = new[] { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
            var dates = new[] { "the first of", "the second of", "the third of", "the fourth of", "the fifth of", "the sixth of", "the seventh of", "the eighth of", "the ninth of", "the tenth of", "the eleventh of", "the twelveth of", "the thirteenth of", "the fourteenth of", "the fifteenth of", "the sixteenth", "the seventeenth", "the eighteenth", "the nineteenth", "the twentieth of", "the twenty first of", "the twenty second of", "the twenty third of", "the twenty fourth of", "the twenty fifth of", "the twenty sixth of", "the twenty seventh of", "the twenty eighth of", "the twenty ninth of", "the thirtieth of", "the thirty first of"};
            int a; int b;
            Console.WriteLine("Enter the day of the month");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of the month");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(dates[a - 1] + ' ' + months[b - 1]);
            Console.ReadKey();
        }
    }
}
