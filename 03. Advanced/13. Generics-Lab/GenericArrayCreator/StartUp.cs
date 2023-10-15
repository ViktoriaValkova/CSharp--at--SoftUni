namespace GenericArrayCreator
{
	internal class StartUp
	{
		static void Main(string[] args)
		{
			string[] strings = ArrayCreator.Create(5, "Pesho");
			int[] integers = ArrayCreator.Create(10, 33);

			Console.WriteLine(integers.Length);
		}
	}
}