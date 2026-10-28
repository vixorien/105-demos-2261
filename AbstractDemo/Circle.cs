// Chris Cascioli
// 10/28/26
// Example of a child class derived from an abstract

namespace AbstractDemo
{
	internal class Circle : Shape
	{
		// Fields
		private double radius;
		
		// Properties
		public double Radius
		{
			get { return radius; }
		}

		// Constructor

		/// <summary>
		/// Creates a colored circle of the given radius
		/// </summary>
		/// <param name="radius">Distance from center to edge</param>
		/// <param name="color">Color when printed</param>
		public Circle(double radius, ConsoleColor color)
			: base(color)
		{
			this.radius = radius;
		}

		// Methods

		/// <summary>
		/// Calculates the area of a circle
		/// </summary>
		/// <returns>Area of this circle</returns>
		public override double CalculateArea()
		{
			return Math.PI * radius * radius;
		}

		/// <summary>
		/// "Draws" the circle
		/// </summary>
		public override void Draw()
		{
			// Change color, draw, reset color
			Console.ForegroundColor = this.Color;
			Console.WriteLine("O");
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}
