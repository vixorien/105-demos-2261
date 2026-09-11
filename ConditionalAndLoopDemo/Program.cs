// Chris Cascioli
// 9/11/26
// Ifs, switches, and loops
// Relational and boolean operators
// Console colors

namespace ConditionalAndLoopDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// === Console colors ===
			Console.WriteLine("What color is this?");

			// Changing color
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("This is white");

			// Dark magenta
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("Dark magenta");

			// Background color
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine("This has a background color");

			// Back to the defaults
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Back to defaults");

			// Mixing colors on a single line
			Console.WriteLine();
			Console.Write("This is ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("blue");
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(" and this is not");
			Console.WriteLine();

			// === Operators ===

			// Relational operators
			int total = 2 + 3;
			bool test = 5 < 10;
			bool same = 99 == 99;

			// Boolean operators
			bool itWorked = true && false; // False!
			bool nope = false || false; // False!
			bool flip = !false; // True!
			bool again = !(5 < 10); // False!

			// Bitwise operators
			bool singleAnd = true & false;
			Console.WriteLine("Result: " + singleAnd);
			
			bool shortCircuit = false && PrintAndReturn();
			Console.WriteLine("Short circuit: " + shortCircuit);


			// === Conditionals ===

			Console.Write("Enter your D&D class: ");
			string charClass = Console.ReadLine()!;

			// Santize the user input
			//charClass = charClass.Trim();
			//charClass = charClass.ToLower();
			charClass = charClass.Trim().ToLower();

			// Ask for character level
			Console.Write("Enter your level: ");
			int level = int.Parse(Console.ReadLine()!);

			// If statements
			string weapon;
			if (charClass == "rogue")
			{
				weapon = "dagger";
				Console.WriteLine("Sneaky sneaky");

				if (level < 5)
				{
					Console.WriteLine("Low level!");
				}
				else if (level < 10)
				{
					Console.WriteLine("Mid tier");
				}
				else
				{
					Console.WriteLine("Higher level");
				}
			}
			else if (charClass == "fighter")
			{
				Console.WriteLine("Sword and board!");
				weapon = "longsword";
			}
			else
			{
				Console.WriteLine("Not yet implemented!");
				weapon = "???";
			}

			Console.WriteLine(weapon);



			// --- Switch ---

			switch (charClass)
			{
				case "rogue":
					Console.WriteLine("Stab 'em!");
					break;

				case "fighter":
					Console.WriteLine("I could do this all day");
					break;

				default:
					Console.WriteLine("No idea");
					break;
			}

			switch (charClass)
			{
				case "paladin":
				case "monk":
				case "rogue": Console.WriteLine("Stab 'em!"); break;
				case "fighter":	Console.WriteLine("I could do this all day"); break;

				default: Console.WriteLine("No idea"); break;
			}

			// === Loops ===
			Console.WriteLine();

			int counter = 0;
			while (counter <= 10)
			{
				Console.WriteLine(counter);
				counter++;
			}

			string name = "";
			do
			{
				Console.Write("Enter your name: ");
				name = Console.ReadLine()!;
			}
			while (name == "");

			// Our "standard" for loop
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
			}

			for (string s = ""; s == ""; s = Console.ReadLine()!)
			{
				Console.Write("Enter your name: ");
			}


		}

		static bool PrintAndReturn()
		{
			Console.WriteLine("PRINT!");
			return true;
		}
	}
}
