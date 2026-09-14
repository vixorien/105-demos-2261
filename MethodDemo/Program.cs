// Chris Cascioli
// 9/14/26
// Demo of methods and XML comments

namespace MethodDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int age = GetUserInt("Enter your age: ");
			Console.WriteLine("Your age: " + age);

			int cats = GetUserInt("Enter number of cats: ");
			Console.WriteLine("You have " + cats + " cats");

		}

		/// <summary>
		/// Prompts the user, parses their 
		/// input and returns the value
		/// </summary>
		/// <param name="prompt">The prompt printed before input</param>
		/// <returns>The int version of the user's input</returns>
		static int GetUserInt(string prompt)
		{
			Console.Write(prompt);
			string input = Console.ReadLine()!.Trim();
			return int.Parse(input);
		}

		/// <summary>
		/// Calculates the area of the given circle
		/// </summary>
		/// <param name="radius">Radius of circle</param>
		/// <returns>Area of circle as Pi * r * r</returns>
		static double CalcCircleArea(double radius)
		{
			return Math.PI * radius * radius;
		}

		
		static bool CirclesOverlap(
			double x1, double y1, double r1, // Circle 1
			double x2, double y2, double r2) // Circle 2
		{
			// Validate incoming data
			if (r1 <= 0 || r2 <= 0)
			{
				return false;
			}

			// Calculate the dist between circles
			double xDiff = x1 - x2;
			double yDiff = y1 - y2;
			double dist = Math.Sqrt(xDiff * xDiff + yDiff * yDiff);

			// One-liner for the final value
			return r1 + r2 > dist;

			// alternative:
			//if (r1 + r2 > dist)
			//	return true;
			//else
			//	return false;
		}

	}
}
