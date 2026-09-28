// Chris Cascioli
// 9/28/26
// Example solution for Word Search PE

namespace WordSearchPossibleSolution
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a 2D array of characters
			// Note: Yours should actually prompt for sizes
			char[,] puzzle = new char[15, 10]; // Height (rows), Width (columns)

			// Fill with random data
			Random rng = new Random();
			for (int row = 0; row < puzzle.GetLength(0); row++)
			{
				for (int col = 0; col < puzzle.GetLength(1); col++)
				{
					// Remember .Next() has an exclusive upper bound
					puzzle[row, col] = (char)rng.Next(97, 123);
				}
			}

			// Display the grid
			for (int row = 0; row < puzzle.GetLength(0); row++)
			{
				for (int col = 0; col < puzzle.GetLength(1); col++)
				{
					Console.Write(puzzle[row, col] + " ");
				}
				Console.WriteLine();
			}

			// Get a word from the user
			Console.WriteLine();
			Console.Write("Search for: ");
			string search = Console.ReadLine()!;

			Console.WriteLine(SearchHorizontal(puzzle, search));

		}

		/// <summary>
		/// Searches a grid horizontally for a given word
		/// </summary>
		/// <param name="puzzle">Grid of characters</param>
		/// <param name="search">Search string</param>
		/// <returns>True if string is in grid, false otherwise</returns>
		static bool SearchHorizontal(char[,] puzzle, string search)
		{
			if (search.Length == 0)
				return false;

			for (int row = 0; row < puzzle.GetLength(0); row++)
			{
				for (int col = 0; col < puzzle.GetLength(1); col++)
				{
					// Work through row and check each character
					int i = 0;
					while (
						i < search.Length &&
						col + i < puzzle.GetLength(1) &&
						puzzle[row, col + i] == search[i])
					{
						i++;
					}

					// Did we make it through the whole string?
					if (i == search.Length)
					{
						return true;
					}


				}
			}


			// No match found
			return false;
		}
	}
}
