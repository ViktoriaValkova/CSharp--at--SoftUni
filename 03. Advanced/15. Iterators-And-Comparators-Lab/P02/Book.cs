namespace IteratorsAndComparators
{
	public class Book
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
	}
}
