// Chris Cascioli
// 9/21/26
// Array And ForEach demo

namespace ArrayAndForEachDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a simple integer array
			int[] numbers = new int[5];

			// Manually filling the array, one at a time
			numbers[0] = 99;
			numbers[1] = -4;
			numbers[2] = 12345;
			numbers[3] = 54;
			numbers[4] = 1;
			//numbers[5] = 2;

			// Literal array
			int[] moreNumbers = { 123, -456, 999, 0, 4 };
			string[] names = { "Bob", "Jim", "Pam", "Jan" };

			PrintArray(numbers);

			Console.WriteLine();
			bool negatives = AnyNegatives(numbers);
			Console.WriteLine("Any negatives? " + negatives);

			Console.WriteLine();
			Console.WriteLine("Highest value: " + HighestValue(numbers));
		}

		/// <summary>
		/// Prints an array, one element per line
		/// </summary>
		/// <param name="array">Array to print</param>
		static void PrintArray(int[] array)
		{
			Console.WriteLine("Array elements: ");

			// For-loop version
			//for (int i = 0; i < array.Length; i++)
			//{
			//	Console.WriteLine(array[i]);
			//}

			// Foreach loop
			foreach (int num in array)
			{
				Console.WriteLine(num);
			}

			Console.WriteLine();
		}

		/// <summary>
		/// Determines if any elements are negative
		/// </summary>
		/// <param name="array">Array to search</param>
		/// <returns>True if at least one element is negative, false otherwise</returns>
		static bool AnyNegatives(int[] array)
		{
			foreach (int num in array)
			{
				if (num < 0)
				{
					return true;
				}
			}

			// No negatives found
			return false;
		}

		/// <summary>
		/// Determines the highest (largest) value in the array
		/// </summary>
		/// <param name="array">Array to search</param>
		/// <returns>Highest/largest value in array</returns>
		static int HighestValue(int[] array)
		{
			// Verify there are elements
			if (array.Length == 0)
			{
				return int.MinValue;
			}

			// Current highest contender
			int highest = array[0];

			// Loop and check each element
			for (int i = 1; i < array.Length; i++)
			{
				// Compare
				if (array[i] > highest)
				{
					highest = array[i];
				}
			}

			// Return the result
			return highest;
		}
	}
}
