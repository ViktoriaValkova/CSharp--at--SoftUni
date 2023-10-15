namespace GenericScale
{
	internal class StartUp
	{
		static void Main(string[] args)
		{
			var test = new EqualityScale<int>(5, 6);
			var first = test.AreEqual();
			var test2 = new EqualityScale<string>("a", "a");
			var second = test2.AreEqual();
			Console.WriteLine(first);
			Console.WriteLine(second);
		}
	}
}