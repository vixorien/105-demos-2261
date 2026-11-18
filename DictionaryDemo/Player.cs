// Chris Cascioli
// 11/18/26
// Simple player object for storage in dictionary

namespace DictionaryDemo
{
	internal class Player
	{
		/// <summary>
		/// Gets or sets the players name
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// Gets or sets the player's score
		/// </summary>
		public int Score { get; set; }

		/// <summary>
		/// Creates a new player
		/// </summary>
		/// <param name="name">Player's unique name</param>
		/// <param name="score">Current score</param>
		public Player(string name, int score)
		{
			Name = name;
			Score = score;
		}
	}
}
