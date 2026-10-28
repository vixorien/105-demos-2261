// Chris Cascioli
// 10/28/26
// Demo of abstract classes and methods

namespace AbstractDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// The parent by itself isn't very useful...
			//Shape s = new Shape(ConsoleColor.Red);
			//s.Draw();

			List<Shape> shapes = new List<Shape>();
			shapes.Add(new Circle(2, ConsoleColor.DarkYellow));
			

			// Make a circle 
			Shape circle = new Circle(4, ConsoleColor.Blue);
			Console.WriteLine("Area of circle: " + circle.CalculateArea());
			circle.Draw();
		}
	}
}
