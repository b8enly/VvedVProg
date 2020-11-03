using System;

namespace _201_725_ЯблонскаяСС_Лаб9_Задание2
{
	class Program
	{
		static void Main(string[] args)
		{
			int k = int.Parse(Console.ReadLine());
			int N = k - (7 * (k / 7));
			Console.WriteLine(N);
			Console.ReadKey();
		}
	}
}

