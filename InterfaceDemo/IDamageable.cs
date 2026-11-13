// Chris Cascioli
// 11/13/26
// Example interface

namespace InterfaceDemo
{
	internal interface IDamageable
	{
		/// <summary>
		/// Gets the amount of damage marked on the object
		/// </summary>
		int CurrentDamage { get; }

		/// <summary>
		/// Adds damage to the object
		/// </summary>
		/// <param name="amount">Incoming damage</param>
		void TakeDamage(int amount);
	}
}
