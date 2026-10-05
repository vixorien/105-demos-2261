// Chris Cascioli
// 10/5/26
// Demo of creating classes and instantiating objects from them

namespace OOPDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create one or more cars
			Car myFirstCar = new Car("Blue", "VW", "Jetta");
			myFirstCar.Print();
			myFirstCar.Drive(5.2);
			myFirstCar.Drive(-10);
			myFirstCar.Print();

			Console.WriteLine();

			// Make a second vehicle
			Car secondCar = new Car();
			secondCar.Print();
		}
	}
}
