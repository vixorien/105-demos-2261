// Chris Cascioli
// 10/26/26
// Example of a basic parent class

namespace PolymorphismDemo
{
	internal class Vehicle
	{
		// Field
		protected string name;

		// Constructor

		/// <summary>
		/// Creates a new named vehicle
		/// </summary>
		/// <param name="name">Name of vehicle</param>
		public Vehicle(string name)
		{
			this.name = name;
		}

		// Method

		/// <summary>
		/// Simulates driving
		/// </summary>
		public virtual void Drive()
		{
			Console.WriteLine($"Vehicle {name} is driving");
		}

		/// <summary>
		/// Return a string representation of the object
		/// </summary>
		/// <returns>String version</returns>
		public override string ToString()
		{
			return "Vehicle named " + name;
		}

	}
}
