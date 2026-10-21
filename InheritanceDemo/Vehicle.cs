// Chris Cascioli
// 10/21/26
// Example of a base (or parent) class

namespace InheritanceDemo
{
	internal class Vehicle
	{
		// Fields
		protected string make;
		protected string model;
		protected double mileage;

		// Properties
		public string Make { get { return make; } } // Example of a "standard" property
		public string Model { get => model; } // Example of an "expression-bodied" property
		public string Color { get; set; } // Example of an "auto property"

		public double Mileage
		{
			get { return mileage; }
		}

		// Constructor

		/// <summary>
		/// Creates a new vehicle
		/// </summary>
		/// <param name="make">Maker</param>
		/// <param name="model">Specific model</param>
		public Vehicle(string make, string model)
		{
			Console.WriteLine("VEHICLE PARAMETERIZED CONSTRUCTOR");

			this.make = make;
			this.model = model;
			this.mileage = 0;

			// Using the property since there's no field
			this.Color = "Black"; 
		}

		// Methods

		/// <summary>
		/// Simulates driving
		/// </summary>
		/// <param name="distance">Distance to travel</param>
		public void Drive(double distance)
		{
			mileage += Math.Abs(distance);
			Console.WriteLine($"Vehicle has driven {distance} miles");
		}
	}
}
