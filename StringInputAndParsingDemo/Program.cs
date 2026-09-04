// Chris Cascioli
// 9/4/26
// Demo of strings, console input and parsing from strings to numbers

namespace StringInputAndParsingDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a few strings
			string name = "Chris";
			string food = "sandwich";

			// Combining strings
			// Note: pressing "cw" followed by TAB will insert a writeline
			Console.WriteLine(name);
			Console.WriteLine(name + food);
			Console.WriteLine(name + " ate a " + food + " yesterday");

			// String methods
			Console.WriteLine(); // A blank line for formatting
			Console.WriteLine(name.ToUpper());
			
			name = name.ToUpper();
			Console.WriteLine(name);


			// Special characters
			Console.WriteLine();
			Console.WriteLine("Hello\nWorld");
			Console.WriteLine("A\tB");
			Console.WriteLine("AAA\tB"); 
			Console.WriteLine("AAAAAAAAAAAAAAA\tB");

			// String interpolation
			// Another mechanism for combining strings & variables
			Console.WriteLine();
			Console.WriteLine(name + " ate a " + food + " yesterday");
			Console.WriteLine($"{name} ate a {food} yesterday");

			// String formatting
			int amount = 10;
			double price = 4000.00;
			Console.WriteLine();
			Console.WriteLine($"{amount:###.###} objects each cost {price:N}");
			Console.WriteLine(price.ToString("C2"));

			// Console input
			Console.WriteLine();
			Console.Write("Enter your first name: ");
			string firstname = Console.ReadLine()!;

			Console.Write("Enter your last name: ");
			string lastname = Console.ReadLine()!;

			Console.Write("Enter your age: ");
			string ageStr = Console.ReadLine()!;

			// Parsing
			// A mechanism for interpreting a string as a number
			Console.WriteLine();
			int age = int.Parse(ageStr);
			Console.WriteLine("Your age doubled is: " + (age * 2));


		}
	}
}
