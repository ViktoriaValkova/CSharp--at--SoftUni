using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
	public class RandomList : List<string>
	{
		private Random rnd;

		public RandomList()
		{
			this.rnd = new Random();
		}

		public string RemoveRandomElement()
		{
			int index = rnd.Next(0,this.Count);
			string result = this[index];
			this.RemoveAt(index);
			return result;
		}

		public string RandomString()
		{
			int index = rnd.Next(0, this.Count);
			string result = this[index];
			return result;
		}

	}
}
