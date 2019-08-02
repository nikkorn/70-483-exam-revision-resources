using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
	class Program
	{
		static void task1()
		{
			Console.WriteLine("task 1 start!");

			Thread.Sleep(2000);

			Console.WriteLine("task 1 end!");
		}

		static void task2()
		{
			Console.WriteLine("task 2 start!");

			Thread.Sleep(1000);

			Console.WriteLine("task 2 end!");
		}

		static void task3(string value)
		{
			Console.WriteLine($"{value}!");

			Thread.Sleep(1000);
		}

		static void Main(string[] args)
		{
			List<string> items = new List<string> { "pears", "bananas", "apples", "watermelons", "lemons" };

			Console.WriteLine("---------------------------------------------------------");

			Parallel.Invoke(() => task1(), () => task2());

			Console.WriteLine("---------------------------------------------------------");

			Parallel.ForEach(items, item => task3(item));

			Console.WriteLine("---------------------------------------------------------");

			Parallel.For(0, items.Count, index => task3(items[index]));

			Console.WriteLine("---------------------------------------------------------");

			Console.ReadKey();
		}
	}
}
