// Chris Cascioli
// 10/26/26
// Demo of polymorphism, downcasting and overriding methods

namespace PolymorphismDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create and test a pure vehicle
			Vehicle car = new Vehicle("Carl");
			car.Drive();
			Console.WriteLine("Calling ToString:     " + car.ToString());
			Console.WriteLine("Not calling ToString: " + car);
			Console.WriteLine();

			// Create and test a derived (child) class
			Firetruck ft = new Firetruck("Freddie");
			ft.Drive();
			ft.Spray();
			Console.WriteLine("Calling ToString: " + ft.ToString());
			Console.WriteLine();

			// Polymorphism
			// - Child object counts as the parent type
			Vehicle vehicleContext = new Firetruck("What am I?");
			vehicleContext.Drive();
			// vehicleContext.Spray(); // Spray() is not in VEHICLE

			// Later in code...
			// - I want to get the vehicle back in the Firetruck context
			// - This is known as a DOWNCAST
			Console.WriteLine();
			Firetruck ftRef = (Firetruck)vehicleContext;
			ftRef.Drive();
			ftRef.Spray();

			// An "inline" cast (use this sparingly!!)
			((Firetruck)vehicleContext).Spray();

			// What if I attempt to cast a parent class
			// object to the child reference?

			// First: Verify the cast COULD work
			// - In other words: Is the object ACTUALLY a firetruck?
			if (car is Firetruck)
			{
				Firetruck nope = (Firetruck)car;
			}
			else
			{
				Console.WriteLine("Car was never a firetruck");
			}

			// Objects within a list of the parent type
			Console.WriteLine();
			List<Vehicle> allVehicles = new List<Vehicle>();
			Random rng = new Random();
			for (int i = 0; i < 10; i++)
			{
				// Generate 0 or 1
				if (rng.Next(2) == 0)
				{
					allVehicles.Add(new Vehicle("Car " + i));
				}
				else
				{
					allVehicles.Add(new Firetruck("Firetruck " + i));
				}
			}

			// Loop and call spray on all firetrucks
			foreach (Vehicle v in allVehicles)
			{
				if (v is Firetruck)
				{
					Firetruck reallyAFiretruck = (Firetruck)v;
					reallyAFiretruck.Spray();
				}
			}

		}
	}
}
