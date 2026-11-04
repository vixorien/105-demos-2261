// Chris Cascioli
// 11/2/26
// A custom generic list data structure using an indexer

namespace IndexerAndGenericDemo
{
	internal class CustomList<T>
	{
		// Fields
		private T[] items;
		private int count;

		// Properties
		public int Count { get { return count; } }

		public int Capacity { get { return items.Length; } }

		/// <summary>
		/// Gets or sets an element of the list
		/// </summary>
		/// <param name="index">The index to get or set</param>
		/// <returns>Data at given index</returns>
		public T this[int index]
		{
			get
			{
				// Validate index
				if (index < 0 || index >= count)
					return default(T)!;

				return items[index];
			}

			set
			{
				// Validate index
				if (index < 0 || index >= count)
					return;

				// Overwrite the data
				items[index] = value;
			}
		}

		// Constructor

		/// <summary>
		/// Creates a new list with default capacity of 4
		/// </summary>
		public CustomList()
		{
			count = 0;
			items = new T[4];
		}

		/// <summary>
		/// Adds an item to the end of the list
		/// </summary>
		/// <param name="item">Data to add</param>
		public void Add(T item)
		{
			// First, verify there is room!
			if (Count == Capacity)
			{
				// Do something useful here
				return; // NOT THIS!
			}

			// Add the item and increment count
			items[count] = item;
			count++;
		}
	}
}
