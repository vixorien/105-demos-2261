// Chris Cascioli
// 11/18/26
// Demo of dictionaries in C#

namespace DictionaryDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Basic dictionary mapping strings to strings
			Dictionary<string, string> dict = new Dictionary<string, string>();

			// Add using .Add()
			dict.Add("Bob", "123 Fake St.");
			dict.Add("Jim", "5 Jim St.");
			dict.Add("Pam", "999 Road Ave.");

			// Adding a key that already exists?
			// Nope, this throws an exception!
			//dict.Add("Bob", "456 Whatever Ave.");

			// Indexer syntax can be used to 
			// both add or replace data
			dict["Larry"] = "1 One St.";
			dict["Bob"] = "124 Fake St.";

			// Getting data out of the dictionary
			string bobAddr = dict["Bob"];
			Console.WriteLine("Bob lives at: " + bobAddr);

			// Test for the key first
			if (dict.ContainsKey("Jan"))
			{
				// This example does two look-ups of the key
				string janAddr = dict["Jan"];
				Console.WriteLine("Jan lives at: " + janAddr);
			}

			// Attempt to get the value with a 
			// single key lookup instead
			string addr;
			if (dict.TryGetValue("Jim", out addr!))
			{
				Console.WriteLine("Jim lives at: " + addr);
			}

			// === Adding objects to a dictionary ===
			Dictionary<string, Player> players = new Dictionary<string, Player>();

			Player p1 = new Player("Pam", 8);
			Player p2 = new Player("Sam", 5);

			players.Add(p1.Name, p1);
			players.Add(p2.Name, p2);

			Console.WriteLine("Pam's score is " + players["Pam"].Score);
		}
	}
}
