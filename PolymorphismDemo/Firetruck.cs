// Chris Cascioli
// 10/26/26
// Example of a child class

namespace PolymorphismDemo
{
	internal class Firetruck : Vehicle
	{
		// Constructor

		public Firetruck(string name) 
			: base(name)
		{

		}

		// Methods

		/// <summary>
		/// Simulates spraying water
		/// </summary>
		public void Spray()
		{
			Console.WriteLine($"Firetruck {name} is spraying water");
		}

		/// <summary>
		/// A firetruck-specific version of Drive
		/// </summary>
		public override void Drive()
		{
			Console.WriteLine($"Firetruck {name} is driving with its siren blaring");
		}

		/// <summary>
		/// Returns string version, utilizing the parent's ToString, too
		/// </summary>
		/// <returns>String version</returns>
		public override string ToString()
		{
			return base.ToString() + " is a firetruck";
		}
	}
}
