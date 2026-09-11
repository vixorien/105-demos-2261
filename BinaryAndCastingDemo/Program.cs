// Chris Cascioli
// 9/9/26
// Demo of binary numbers and type casting between numeric types

namespace BinaryAndCastingDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Example of imprecision of doubles
			double sum = 0.1 + 0.2;
			Console.WriteLine("Sum: " + sum);

			// Example of an implicit cast
			short small = 10;
			int large = small;

			// Example of an explicit cast
			large = 9999999;
			small = (short)large;

			// What happens to the number after the cast?
			Console.WriteLine("Number after cast: " + small);

			// Conversion between int and double
			int whole = 4;
			double fractional = whole;

			double pi = 3.14159;
			int mostlyPi = (int)pi;

			// Printing the binary of an integer type
			int example = 51;
			Console.WriteLine("Number: " + example);
			Console.WriteLine($"Number as binary: {example:b}"); // b = convert to binary
		}
	}
}
