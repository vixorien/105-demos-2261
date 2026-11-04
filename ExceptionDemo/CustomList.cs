// Chris Cascioli
// 11/2/26
// A custom generic list data structure using an indexer

namespace ExceptionDemo
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
				{
					throw new ArgumentOutOfRangeException(
						"index", 
						"Index was out of range, valid range is ....");
				}

				return items[index];
			}

			set
			{
				// Validate index
				if (index < 0 || index >= count)
				{
					throw new ArgumentOutOfRangeException(
						"index",
						"Index was out of range, valid range is ....");
				}

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

		/// <summary>
		/// Inserts data and specified index
		/// </summary>
		/// <param name="index">Where to put the data</param>
		/// <param name="item">New item to add</param>
		/// <exception cref="ArgumentOutOfRangeException">Index is negative or greater than count</exception>
		public void Insert(int index, T item)
		{
			// Validate index
			if (index < 0 || index > count)
			{
				throw new ArgumentOutOfRangeException(
					"index",
					"Index was out of range, valid range is ....");
			}

			// First, verify there is room!
			if (Count == Capacity)
			{
				// Do something useful here
				return; // NOT THIS!
			}

			// Make room for the new item
			for (int i = count; i > index; i--)
			{
				items[i] = items[i - 1];
			}

			// Replace with the incoming data
			items[index] = item;
			count++;
		}
	}
}
