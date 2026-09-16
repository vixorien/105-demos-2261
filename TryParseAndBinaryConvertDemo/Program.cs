// Chris Cascioli
// 9/16/26
// Demo of TryParse() and the binary converter PE

namespace TryParseAndBinaryConvertDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// === Try Parse demo ===
			int num;
			do
			{
				// Ask the user for a number
				Console.Write("Enter a number: ");
			}
			while (!int.TryParse(Console.ReadLine()!, out num)) ;
			
			Console.WriteLine($"{num} doubled is {num * 2}");

			// === Binary to Int ===
			Console.WriteLine();
			Console.Write("Enter binary: ");
			string binary = Console.ReadLine()!;

			int result = BinaryToInteger(binary);
			Console.WriteLine("Converted: " + result);

		}

		/// <summary>
		/// Return the int equivalent of the given binary string
		/// </summary>
		/// <param name="s">String of 0s and 1s</param>
		/// <returns>Integer version of input, or -1 if invalid</returns>
		static int BinaryToInteger(string s)
		{
			// Validate the input
			if (s.Length == 0 || s.Length > 30)
			{
				return -1;
			}

			int total = 0;

			// Loop through characters of string
			for (int i = s.Length - 1; i >= 0; i--)
			{
				// - Validate each character
				char c = s[i]; // Isolate the current character
				if (c != '0' && c != '1') // TODO: TEST!!!
				{
					return -1;
				}

				// - Use the "place" to convert to a power of 2
				if (c == '1')
				{
					int power = s.Length - 1 - i;
					total += (int)Math.Pow(2, power);
				}

			}

			// Return the result
			return total;
		}
	}
}
