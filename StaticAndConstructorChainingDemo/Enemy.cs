// Chris Cascioli
// 10/7/26
// Example of a class, static members and constructor chaining

using System.Runtime.CompilerServices;

namespace StaticAndConstructorChainingDemo
{
	internal class Enemy
	{
		// Fields
		private int x;
		private int y;
		private string sprite;
		private ConsoleColor color;

		// Static fields
		private static int enemyCount = 0;

		// Constructors

		/// <summary>
		/// Creates an enemy to be printed to the console
		/// </summary>
		/// <param name="x">X position in console</param>
		/// <param name="y">Y position in console</param>
		/// <param name="sprite">String to print</param>
		/// <param name="color">Color of sprite</param>
		public Enemy(int x, int y, string sprite, ConsoleColor color)
		{
			this.x = x;
			this.y = y;
			this.sprite = sprite;
			this.color = color;

			// Increment the static count
			enemyCount++;
		}

		/// <summary>
		/// Creates an enemy using a default sprite and color
		/// </summary>
		/// <param name="x">X position in console</param>
		/// <param name="y">Y position in console</param>
		public Enemy(int x, int y)
			: this(x, y, "O.O", ConsoleColor.White)
		{ }

		// Methods

		/// <summary>
		/// Prints the static enemy count
		/// </summary>
		public static void ExampleStaticMethod()
		{
			Console.WriteLine("Enemy Count: " + enemyCount);
		}

		/// <summary>
		/// Moves the cursor and prints the enemy
		/// </summary>
		public void Print(ConsoleColor bgColor = ConsoleColor.Black)
		{
			// Move the cursor
			Console.CursorLeft = x;
			Console.CursorTop = y;

			// Change color
			ConsoleColor prevColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.BackgroundColor = bgColor;

			// Print sprite
			Console.Write(sprite);

			// Change color back
			Console.ForegroundColor = prevColor;
		}
	}
}
