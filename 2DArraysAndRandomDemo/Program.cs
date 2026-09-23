// Chris Cascioli
// 9/23/26
// Demo of Arrays of strings, 2D arrays and random numbers

namespace ArraysAndRandomDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create several arrays
			int[] numbers = new int[5];
			string[] names = new string[10];

			string today = "Wednesday";
			Console.WriteLine(today.ToUpper());

			// Print the upper case version of the first name
			//Console.WriteLine(names[0].ToUpper());
			// Error!  names[0] is current NULL!

			// === Multidimensional arrays ===

			// Jagged array
			// - Requires creating the "outer" array first
			int[][] jaggedGrid = new int[5][];

			// Now we can create the "inner" arrays
			jaggedGrid[0] = new int[4];
			jaggedGrid[1] = new int[4];
			jaggedGrid[2] = new int[2];
			jaggedGrid[3] = new int[7];
			jaggedGrid[4] = new int[3];

			// Using a jagged array
			jaggedGrid[0][0] = 99;
			jaggedGrid[0][1] = 101;
			// Etc.

			// True multi-dimension arrays
			int[,] regularGrid = new int[5, 3];

			// Fill up with some numbers
			regularGrid[0, 0] = 99;
			regularGrid[0, 1] = 99;
			regularGrid[0, 2] = 99;

			// Creating a literal multi-dimensional array
			double[,] matrix =
			{
				{ 1, 0, 0, 0 },
				{ 0, 1, 0, 0 },
				{ 0, 0, 1, 0 },
				{ 4, 5, 6, 1 }
			};

			// Print the matrix
			// - Note: .Length gives the TOTAL number of elements
			for (int y = 0; y < matrix.GetLength(1); y++)
			{
				for (int x = 0; x < matrix.GetLength(0); x++)
				{
					Console.Write(matrix[y,x] + " ");
				}
				Console.WriteLine();
			}

			// You can get weird with it
			int[,,,,,,,] what = new int[3, 3, 3, 3, 3, 3, 3, 3];

			// === Random numbers ===

			// First, create the Random object
			Random rng = new Random();
			
			Console.WriteLine();
			Console.WriteLine("10 random numbers: ");

			// Generating a non-negative random number
			Console.WriteLine(rng.Next());
			Console.WriteLine(rng.Next(10));
			Console.WriteLine(rng.Next(-10, 10));

			Console.WriteLine(rng.NextDouble());
			Console.WriteLine(rng.NextDouble() * 10);
			Console.WriteLine(rng.NextDouble() * 20 - 10);
		}
	}
}
