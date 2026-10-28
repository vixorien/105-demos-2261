// Chris Cascioli
// 10/28/26
// Example of an abstract parent class with abstract and regular methods

namespace AbstractDemo
{
	internal abstract class Shape
	{
		// Fields
		private ConsoleColor color;

		// Properties
		public ConsoleColor Color
		{
			get { return color; }
			set { color = value; }
		}

		// Constructor

		/// <summary>
		/// Creates a new basic shape
		/// </summary>
		/// <param name="c">Color of shape</param>
		public Shape(ConsoleColor c)
		{
			color = c;
		}

		// Methods

		/// <summary>
		/// Example "regular" method
		/// </summary>
		public void Example()
		{
			Console.WriteLine("I am a regular method!");
		}

		/// <summary>
		/// Calculates the area of this shape (and
		/// can be overridden in a child class)
		/// </summary>
		/// <returns>The area of this shape</returns>
		public abstract double CalculateArea();

		/// <summary>
		/// "Draws" the shape on the screen
		/// </summary>
		public abstract void Draw();
	}
}
