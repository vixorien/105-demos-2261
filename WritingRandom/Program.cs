// Chris Cascioli
// 9/28/26
// Example of writing a simple random number generator

namespace WritingRandom
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int SampleSize = 9999999;
			const int UpperBound = 20;

			// Count of each generated value
			int[] values = new int[UpperBound];

			for (int i = 0; i < SampleSize; i++)
			{
				// Increment the corresponding index
				values[Rand(UpperBound)]++;
			}

			PrintPercentages(values, SampleSize);
		}

		static void PrintPercentages(int[] values, int samples)
		{
			for (int i = 0; i < values.Length; i++)
			{
				// Calculate percentage of this value
				double percent = values[i] / (double)samples;
				Console.WriteLine($"{i}: {Math.Round(percent * 100, 3)}%");
			}

		}

		// These variables are """global"""
		const int Seed = 21; // Arbitrary seed
		static int RandNum = Seed; // Changes each generation

		static int Rand(int max)
		{
			RandNum *= Seed;
			RandNum += 54321;
			return Math.Abs(RandNum % max);
		}
	}
}
