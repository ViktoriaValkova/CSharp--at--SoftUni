using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
	public class StackOfStrings : Stack<String>

	{
		private Stack<string> _stack;

		public StackOfStrings()
		{
			this._stack=new Stack<string>();
		}

		public Stack<string> Stack
		{
			get { return _stack; }
			set { this._stack = value; }
		}
		public bool IsEmpty()
		{
			return this.Count == 0;
		}

		public void AddRange(Stack<string>range)
		{
			foreach (string str in range)
			{
				this.Push(str);
			}

		}
 	}
}
