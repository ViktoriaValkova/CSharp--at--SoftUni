namespace SoftUniKindergarten
{
    public class Child :IComparable<Child>
    {
	    public string FirstName { get; set; }
	    public string ParentName { get; set; }
	    public string ContactNumber { get; set; }

	    public string LastName { get; set; }

	    public int Age { get; set; }

	    public string FullName { get; private set; }

	    public Child(string firstName, string lastName, int age, string parentName, string number)
	    {
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
			this.ParentName = parentName;
			this.ContactNumber = number;
			this.FullName = firstName+" "+lastName;
	    }


	    public override string ToString()
	    {
		    return $"Child: {this.FirstName} {this.LastName}, Age: {this.Age}, Contact info: {this.ParentName} - {this.ContactNumber}";
	    }

		public int CompareTo(Child other)
		{
			int result=other.Age.CompareTo(this.Age);

			if ( result== 0)
			{
				result = this.LastName.CompareTo(other.LastName);
			}

			if (result == 0)
			{
				result = this.FirstName.CompareTo(other.FirstName);
			}

			return result;
		}
	}
}
