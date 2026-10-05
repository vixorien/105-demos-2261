// Chris Cascioli
// 10/5/26
// First example of a custom class data structure

namespace OOPDemo
{
	/// <summary>
	/// Simple car representation
	/// </summary>
	internal class Car
	{
		// Fields: Data of the class
		// - Should ALWAYS be private
		private string make;
		private string model;
		private string color;
		private double mileage;

		// Constructors
		// - Give valid initial values to all fields

		/// <summary>
		/// Default constructor for a basic car
		/// </summary>
		public Car()
		{
			// Default values for a simple car
			color = "Black";
			make = "Honda";
			model = "Civic";
			mileage = 0;
		}

		/// <summary>
		/// Gives initial data to the fields of the class
		/// </summary>
		/// <param name="color">Paint color</param>
		/// <param name="make">Maker of the car</param>
		/// <param name="model">Specific model name</param>
		public Car(string color, string make, string model)
		{
			// Save the incoming data
			this.color = color;
			this.make = make;
			this.model = model;
			this.mileage = 0;
		}

		// Methods of the class
		// - Generally public access modifier

		/// <summary>
		/// Simulates the car driving 
		/// </summary>
		/// <param name="distance">How far to drive</param>
		public void Drive(double distance)
		{
			// Validate distance
			if (distance <= 0.0)
			{
				return; // Exit early
			}

			Console.WriteLine($"Car drives {distance} miles");
			mileage += distance;
		}

		/// <summary>
		/// Prints basic data of the class
		/// </summary>
		public void Print()
		{
			Console.WriteLine($"{color} {make} {model} has {mileage} miles.");
		}

	}
}
