namespace DefiningClasses
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			Person newPerson = new Person();
			newPerson.Age = 20;
			newPerson.Name = "Peter";

			Person p = new Person()
			{
				Age = 20,
				Name = "Peter"
			};
		}
	}
}