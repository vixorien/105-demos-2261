// Chris Cascioli
// 11/13/26
// Example of a class implementing an interface

using System.Runtime.Serialization;

namespace InterfaceDemo
{
	internal class Player : IDamageable
	{
		// Fields
		private string name;
		private int damage;

		// Properties

		/// <summary>
		/// Gets the name
		/// </summary>
		public string Name { get { return name; } }

		/// <summary>
		/// Gets the damage set on the object
		/// </summary>
		public int CurrentDamage
		{
			get { return damage; }
		}

		// Constructor
		/// <summary>
		/// Creates a new named player
		/// </summary>
		/// <param name="name">Player's name</param>
		public Player(string name)
		{
			this.name = name;
			this.damage = 0;
		}

		// Methods

		/// <summary>
		/// Adds damage to the object
		/// </summary>
		/// <param name="amount">Incoming damage</param>
		public void TakeDamage(int amount)
		{
			damage += amount;
		}

		/// <summary>
		/// Shoot at anything that counts as damageable
		/// </summary>
		/// <param name="target">Target that implements the correct interface</param>
		public void Shoot(IDamageable target)
		{
			target.TakeDamage(5);
		}
	}
}
