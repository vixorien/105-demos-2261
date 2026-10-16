// Chris Cascioli
// 10/16/26
// Demo of encapsulation and properties

namespace PropertyDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a simple car
			Car car = new Car("Honda", "Civic", "White");
			car.Print();

			// Get the make of the car
			string make = car.Make;

			// Use the car's color
			string carColor = car.Color;
			car.Color = null;
			car.Color = "Red";
			Console.WriteLine(car.Color);

			// Change the mileage
			// Note: Each of these is utilizing both
			// the get and set blocks
			car.Mileage++;
			car.Mileage += 1;
			car.Mileage = car.Mileage + 1;
		}
	}
}
