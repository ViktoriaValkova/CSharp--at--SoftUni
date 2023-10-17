namespace IteratorsAndComparators
{
	public class Book : IComparable<Book>
	{

		public Book(string name, int year, params string[] authors)
		{
			this.Title = name;
			this.Year = year;
			this.Authors = new List<string>(authors);
		}
		public string Title { get; set; }

		public int Year { get; set; }

		public List<string> Authors { get; set; }

		public int CompareTo(Book? other)
		{
			if (this.Year.CompareTo(other.Year) == 0)
			{
				return this.Title.CompareTo(other.Title);
			}
			return this.Year.CompareTo(other.Year);
		}

		public override string ToString()
		{
			return $"{this.Title} - {this.Year}"; 
		}
	}
}
