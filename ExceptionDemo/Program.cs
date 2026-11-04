// Chris Cascioli
// 11/4/26
// Demo of exceptions and try/catch blocks

using System.Diagnostics;

namespace ExceptionDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int num = 5;
				int result = 10 / num;
				Console.WriteLine("Dividing finished");

				int[] array = new int[10];
				array[99] = 99;
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			Console.WriteLine();

			// Testing a list's exceptions
			CustomList<int> numbers = new CustomList<int>();
			numbers.Add(3);
			numbers.Add(4);
			numbers.Add(5);
			numbers.Insert(1, 500);

			try
			{
				numbers[99] = 10;
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("Problem: " + e.Message);
			}

		}
	}
}
