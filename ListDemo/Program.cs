// Chris Cascioli
// 10/2/26
// Demo of basic List<T> creation and usage

namespace ListDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create an array of ints and a List<int>
			int[] intArray = new int[10];
			List<int> nums = new List<int>();

			// How much data exists in the list to start?
			Console.WriteLine("How many items in list? " + nums.Count);

			// Add some items
			Console.WriteLine("Adding items...");
			nums.Add(44);
			nums.Add(-2);
			nums.Add(0);
			nums.Add(99);

			// Insert puts data anywhere in the list
			nums.Insert(0, 1234);

			// Overwrite data
			nums[1] = 33;
			nums[2] -= 10;
			nums[3] *= 100;

			// Can NOT add "new" data using [] notation
			//nums[5] = 1111; // Will crash when Count <= 5

			// Print count again
			Console.WriteLine();
			Console.WriteLine("How many items in list? " + nums.Count);

			// Loop and print the items
			Console.WriteLine();
			Console.WriteLine("List contents:");
			for (int i = 0; i < nums.Count; i++)
			{
				Console.WriteLine(nums[i]);
			}

			// Other useful methods
			nums.Remove(9999);
			nums.Remove(33);
			nums.RemoveAt(0);

			// Print whatever's left
			Console.WriteLine();
			Console.WriteLine("Remaining in list:");
			foreach (int item in nums)
			{
				Console.WriteLine(item);
			}
		}
	}
}
