using System.Collections;

namespace IteratorsAndComparators
{
	public class Library : IEnumerable<Book>
	{
		public List<Book> Books { get; set; }
		public Library(params Book[] books)
		{
			this.Books= new List<Book>(books);
		}


		public IEnumerator<Book> GetEnumerator()
		{
			return new LibraryIterator(this.Books);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		private class LibraryIterator : IEnumerator<Book>
		{
			private readonly List<Book> _Books;
			private int currentIndex;

			public LibraryIterator(IEnumerable<Book> books)
			{
				this._Books = new List<Book>(books);
				this.Reset();
			}

			public Book Current => _Books[currentIndex];

			object IEnumerator.Current =>this.Current;

			public void Dispose()
			{
				
			}

			public bool MoveNext()
			{
				currentIndex++;
				return currentIndex<_Books.Count;
			}

			public void Reset()
			{
				currentIndex = -1;
			}
		}


	}
}
