namespace DefiningClasses
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			Person p = new Person();
			Console.WriteLine(p.Name);
			Console.WriteLine(p.Age);

			Person second = new Person(25);
			Console.WriteLine(second.Name);
			Console.WriteLine(second.Age);

			Person third = new Person("Ivan", 15);
			Console.WriteLine(third.Name);
			Console.WriteLine(third.Age);

		}
	}
}