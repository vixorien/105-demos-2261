// Chris Cascioli
// 9/23/26
// Demo of arrays of objects, multi-dimensional arrays and random numbers

namespace ArrayAndRandomDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// == Arrays of objects ==
			
			// Array of primitives
			int[] numbers = new int[5];
			numbers[0] += 8; // Works fine
			Console.WriteLine("Number: " + numbers[0]);

			string[] names = new string[10];
			Console.WriteLine("Name: " + names[0]);

			// Will crash since the element is NULL!
			// - No string exists here yet
			//Console.WriteLine("Upper case: " + names[0].ToUpper());

			// === Multi-dimensional arrays ===

			// One dimensional array
			int[] oneDim = new int[6];
			int[][] jagged = new int[5][];
			jagged[0] = new int[4];
			jagged[1] = new int[4];
			jagged[2] = new int[7];
			jagged[3] = new int[2];
			jagged[4] = new int[3];

			// Set the data in the jagged array
			jagged[2][3] = 99;

			// Alternatively: A true multidimensional array
			int[,] multiDim = new int[5, 3];
			multiDim[0, 0] = 99;
			multiDim[0, 1] = 101;

			// Lets get weird
			int[][][][] uhh = new int[5][][][];
			int[,,,,,,,,] what = new int[2,2,2,2,2,2,2,2,2];

			int[,] matrix = {
				{ 1, 0, 0 },
				{ 0, 1, 0 },
				{ 0, 0, 1 },
				{ 4, 5, 6 }
			};

			Console.WriteLine("Matrix elements: " + matrix.Length);

			// Print the 2D array as rows and columns of numbers
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					Console.Write(matrix[row, col] + " ");
				}
				Console.WriteLine();
			}


			// === Random numbers ===
			// Step 1: Create a "Random" object
			Random rng = new Random();

			// Step 2: Call functions to generate numbers
			Console.WriteLine();

			// Options for integers
			Console.WriteLine(rng.Next()); // 0 up to MaxValue (exclusive)
			Console.WriteLine(rng.Next(10)); // 0 up to given max (exclusive)
			Console.WriteLine(rng.Next(-20, 20)); // Min up to given max (exclusive)

			Console.WriteLine(rng.NextDouble()); // 0 - 1 (exclusive upper bound)
			Console.WriteLine(rng.NextDouble() * 10); // 0 - 10 (exclusive)
			Console.WriteLine(rng.NextDouble() * 40 - 20); // -20 - 20 (exclusive)

		}
	}
}
