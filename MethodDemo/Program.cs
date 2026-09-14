// Chris Cascioli
// 9/14/26
// Demo of methods and XML comments

namespace MethodDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int age = GetUserNumber("Enter your age: ");
			Console.WriteLine("Your age is..." + age);

			int cats = GetUserNumber("How many cats: ");
			Console.WriteLine("You have this many cats: " + cats);
		}

		/// <summary>
		/// Prompts the user with a specified
		/// prompt string for a number
		/// and parses it to an integer
		/// </summary>
		/// <param name="prompt">String to print before input</param>
		/// <returns>Int parsed from user input</returns>
		static int GetUserNumber(string prompt)
		{
			Console.Write(prompt);
			string input = Console.ReadLine()!.Trim();
			return int.Parse(input);
		}

		/// <summary>
		/// Prompts the user for a number
		/// and parses it to an integer
		/// </summary>
		/// <returns>Int parsed from user input</returns>
		static int GetUserNumber()
		{
			return GetUserNumber("Enter a number: ");
		}

		/// <summary>
		/// Calculates the area of a circle
		/// (Pi * r^2)
		/// </summary>
		/// <param name="radius">Radius of a circle</param>
		/// <returns>Area of given circle</returns>
		static double CalcCircleArea(double radius)
		{
			return Math.PI * radius * radius;
		}

		/// <summary>
		/// Determines if two circles are overlapping
		/// </summary>
		/// <param name="x1">Circle 1's x position</param>
		/// <param name="y1">Circle 1's y position</param>
		/// <param name="r1">Circle 1's radius</param>
		/// <param name="x2">Circle 2's x position</param>
		/// <param name="y2">Circle 2's y position</param>
		/// <param name="r2">Circle 2's radius</param>
		/// <returns>True if circles overlap, false if not</returns>
		public bool CirclesOverlap(
			double x1, double y1, double r1, // Circle 1
			double x2, double y2, double r2) // Circle 2
		{
			// Validate incoming parameters
			// Not handling negative radii
			if (r1 <= 0 || r2 <= 0)
			{
				return false;
			}

			// Calc distance between circle centers
			double xDiff = x1 - x2;
			double yDiff = y1 - y2;
			double dist = Math.Sqrt(xDiff * xDiff + yDiff * yDiff);

			// Determine if the circles overlap
			return r1 + r2 > dist;

			// Alternatively:
			//if (r1 + r2 > dist)
			//{
			//	return true;
			//}
			//else
			//{
			//	return false;
			//}
		}

	}
}
