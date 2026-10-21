// Chris Cascioli
// 10/21/26
// Example of inheritance with a child and parent class

namespace InheritanceDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Test a vehicle
			Vehicle v = new Vehicle("Honda", "Fit");
			v.Drive(5);
			Console.WriteLine();

			// Test a car
			Car c = new Car("VW", "Jetta", 4);
			c.Drive(10);
			c.PrintCarStats();

		}
	}
}
