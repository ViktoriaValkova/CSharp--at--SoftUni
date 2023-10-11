
namespace DefiningClasses
{
	public class Family
	{
		public Family()
		{
			People = new List<Person>();  // important, otherwise not initialized 
		}

		private List<Person> people;

		public List<Person> People
		{
			get { return people; }
			set { people = value; }
		}

		public void AddMember(Person person)
		{
			this.People.Add(person);
		}

		public Person GetOldestMember()
		{
			Person oldestPerson = People.MaxBy(p=>p.Age) ;
			return oldestPerson;
		}

	}
}
