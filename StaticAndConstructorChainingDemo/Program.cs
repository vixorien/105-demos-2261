// Chris Cascioli
// 10/7/26
// Demo of static, constructor chaining and optional parameters

namespace StaticAndConstructorChainingDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a list of enemies
			List<Enemy> enemies = new List<Enemy>();
			enemies.Add(new Enemy(10, 5, ":D", ConsoleColor.Green));
			enemies.Add(new Enemy(12, 3, ">.>", ConsoleColor.Magenta));
			enemies.Add(new Enemy(5, 2));
			enemies.Add(new Enemy(13, 4));

			// Test static method as ClassName.MethodName()
			Enemy.ExampleStaticMethod();

			// Print each enemy
			foreach (Enemy e in enemies)
			{
				e.Print(ConsoleColor.Cyan);
			}

			// Pause
			Console.ReadKey();
		}

	}
}
