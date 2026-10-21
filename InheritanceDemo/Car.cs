// Chris Cascioli
// 10/21/26
// Example of a derived (or child) class

namespace InheritanceDemo
{
	internal class Car : Vehicle
	{
		// Fields
		private int doors;

		// Property

		/// <summary>
		/// Gets the number of doors on the car
		/// </summary>
		public int Doors { get { return doors; } }

		// Constructor

		/// <summary>
		/// Creates a car
		/// </summary>
		/// <param name="make">Car maker</param>
		/// <param name="model">Specific model</param>
		/// <param name="doors">Number of doors</param>
		public Car(string make, string model, int doors) 
			: base(make, model)
		{
			Console.WriteLine("CAR CONSTRUCTOR");

			// Save the car-specific data
			this.doors = doors;
		}

		// Method

		/// <summary>
		/// Prints data about the car
		/// </summary>
		public void PrintCarStats()
		{
			Console.WriteLine("This is a car ----");
			Console.WriteLine("Make: " + make);
			Console.WriteLine("Model: " + model);
			Console.WriteLine("Mileage: " + mileage);
			Console.WriteLine("Color: " + Color); // Property!
			Console.WriteLine("Doors: " + doors);
		}
	}
}
