// Chris Cascioli
// 11/13/26
// Example of a simple "data structure" that
// implements IEnumerable, and also provides
// an enumerator that implements IEnumerator

using System.Collections;

namespace InterfaceDemo
{
	/// <summary>
	/// An inventory class that implements
	/// IEnumerable, which allows an object
	/// to be "enumerated" (looped through)
	/// </summary>
	internal class Inventory : System.Collections.IEnumerable
	{
		private string[] items = {
			"Sword",
			"Potion of Healing",
			"Shield",
			"Boots",
			"Rope"
		};

		/// <summary>
		/// Gets the size of our inventory
		/// </summary>
		public int Size { get { return items.Length; } }

		/// <summary>
		/// Gets or sets an item in the inventory
		/// </summary>
		/// <param name="index">Index of item</param>
		/// <returns>Item string</returns>
		public string this[int index]
		{
			get { return items[index]; }
			set { items[index] = value; }
		}

		/// <summary>
		/// Creates a new inventory
		/// </summary>
		public Inventory() { }

		/// <summary>
		/// Gets an enumerator for our object
		/// </summary>
		/// <returns>New enumerator for inventory</returns>
		public IEnumerator GetEnumerator()
		{
			return new InventoryEnumerator(this);
		}
	}

	internal class InventoryEnumerator : IEnumerator
	{
		// Fields
		private Inventory inv;
		private int position;

		// Properties
		public object Current { get { return inv[position]; } }

		// Constructor
		/// <summary>
		/// Creates a new enumerator for an inventory
		/// </summary>
		/// <param name="inv">The inventory to loop through</param>
		public InventoryEnumerator(Inventory inv)
		{
			this.inv = inv;
			this.position = -1;
		}

		// Methods

		/// <summary>
		/// Moves to the next spot
		/// </summary>
		/// <returns>Whether or not the spot is valid</returns>
		public bool MoveNext()
		{
			position++;
			return position < inv.Size;
		}

		/// <summary>
		/// Resets position to default starting pos
		/// </summary>
		public void Reset()
		{
			position = -1;
		}
	}
}
