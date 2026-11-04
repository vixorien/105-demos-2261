// Chris Cascioli
// 11/2/26
// Demo of indexers and generics

namespace IndexerAndGenericDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CustomList<int> numbers = new CustomList<int>();

			numbers.Add(5);
			numbers.Add(6);
			numbers.Add(7);
			numbers.Add(8);
			numbers.Add(9);

			Console.WriteLine(numbers.Count);

			Console.WriteLine("Item at 3: " + numbers[3]);
		}
	}
}
