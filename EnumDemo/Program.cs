// Chris Cascioli
// 10/28/26
// Demo of enumerations

namespace EnumDemo
{
	/// <summary>
	/// A enumeration of days of the week
	/// </summary>
	enum Day
	{
		Sunday,
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday
	}

	/// <summary>
	/// Example pizza toppings
	/// </summary>
	enum PizzaTopping
	{
		Cheese = 1,
		Sausage = 2,
		Ham = 4,
		Peppers = 8,
		Onion = 16
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a variable to hold the current day
			Day today = Day.Wednesday;

			// What happens when we print an enum?
			Console.WriteLine("Today: " + today);

			// Can we cast between enums and ints?
			int todayNum = (int)today;
			today = (Day)2;

			// Can we do math with enums?
			today++;

			// Check the days
			if (today == Day.Monday)
			{
				Console.WriteLine("The worst");
			}
			else if (today == Day.Tuesday)
			{
				Console.WriteLine("Slightly better");
			}
			else if (today == Day.Wednesday)
			{
				Console.WriteLine("Halfway there");
			}

			// Casting a number that is NOT in the enum
			today = (Day)99;
			Console.WriteLine("What is today after a cast? " + today);

			// Testing pizza toppings
			PizzaTopping topping = (PizzaTopping)4;
			Console.WriteLine("Topping: " + topping);
			Console.WriteLine(topping == PizzaTopping.Ham);
		}
	}
}
