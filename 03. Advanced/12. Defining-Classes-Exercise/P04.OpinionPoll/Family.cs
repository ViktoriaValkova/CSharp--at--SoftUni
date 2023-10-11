
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

		public List<Person> GetPeopleOrderThan30()
		{
			List<Person> olderThan30 = People.Where(p=>p.Age>30).ToList() ;
			return olderThan30;
		}

	}
}
