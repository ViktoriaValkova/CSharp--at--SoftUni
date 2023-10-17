using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
	public class BookComparator : IComparer<Book>
	{
		public int Compare(Book? x, Book? y)
		{
			int resultOfCompare = x.Title.CompareTo(y.Title);
			if (resultOfCompare == 0)
			{
				resultOfCompare = y.Year.CompareTo(x.Year);
			}

			return resultOfCompare;
		}
	}
}
