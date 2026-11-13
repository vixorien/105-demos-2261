// Chris Cascioli
// 11/13/26
// Demo of interfaces

namespace InterfaceDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Player p1 = new Player("Bob");
			Player p2 = new Player("Pam");

			// Both can be implicitly cast to IDamageable
			List<IDamageable> targets = new List<IDamageable>();
			targets.Add(p1);
			targets.Add(p2);

			// Shoot at another player
			p1.Shoot(targets[1]);
			Console.WriteLine(p2.Name + " has taken damage: " + p2.CurrentDamage);
			Console.WriteLine();

			// Create and print our inventory
			Inventory inv = new Inventory();
			foreach (string item in inv)
			{
				Console.WriteLine(item);
			}
		}
	}
}
