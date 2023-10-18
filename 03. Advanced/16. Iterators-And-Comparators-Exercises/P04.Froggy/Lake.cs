using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Froggy
{
	public class Lake : IEnumerable<int>
	{

		public Lake(List<int> stones)
		{this.Stones = stones;
		}
		public List<int> Stones { get; set; }

		public IEnumerator<int> GetEnumerator()
		{
			int i = 0;
			for ( i = 0; i < Stones.Count; i+=2)
			{
				yield return Stones[i];
			}

			int j = 0;
			if (Stones.Count % 2 == 0)
			{
				j =i-1;
			}
			else
			{
				j = i - 3;
			}

			for (int z = j; z >= 0; z-=2)
			{
				yield return Stones[z];
			}

		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
