// Chris Cascioli
// 10/16/26
// Demo of a class with encapsulated fields
// that are exposed via properties

namespace PropertyDemo
{
	internal class Car
	{
		// Fields
		
		private string model;
		private string color;
		private double mileage;

		// Properties

		/// <summary>
		/// Gets the make of the car
		/// Note: This is an example of an AUTO-IMPLEMENTED PROPERTY
		/// that creates its own backing field.  It is NOT tied
		/// to any explicitly defined field in the class.
		/// </summary>
		public string Make { get; private set; }

		/// <summary>
		/// Gets the model of the car
		/// </summary>
		public string Model { get { return model; } }

		/// <summary>
		/// Gets or sets the paint color.  Does not
		/// accept null or an empty string.
		/// </summary>
		public string Color
		{
			get { return color; }
			set 
			{
				// This ensures we don't accept invalid values
				if (value != null && value != "")
				{
					color = value;
				}
			}
		}

		/// <summary>
		/// Gets or sets the mileage.  New mileage
		/// is only accepted if it's higher.
		/// </summary>
		public double Mileage
		{
			get { return mileage; }
			set 
			{
				// Only take the new value if it's higher
				if (value > mileage)
				{
					mileage = value;
				}
			}
		}

		/// <summary>
		/// Gets whether the car is used.  Note
		/// that this property does not have its
		/// own "backing field" - it is derived
		/// from another field
		/// </summary>
		public bool IsUsed
		{
			get { return mileage > 0; }
		}


		// Constructor
		/// <summary>
		/// Creates a car object
		/// </summary>
		/// <param name="make">Maker of the car</param>
		/// <param name="model">Specific model</param>
		/// <param name="color">Paint color</param>
		public Car(string make, string model, string color)
		{
			this.Make = make;
			this.model = model;
			this.color = color;
			mileage = 0;
		}

		// Methods

		/// <summary>
		/// Prints car stats
		/// </summary>
		public void Print()
		{
			Console.WriteLine($"{color} {Make} {model} has {mileage} miles");
		}
	}
}
