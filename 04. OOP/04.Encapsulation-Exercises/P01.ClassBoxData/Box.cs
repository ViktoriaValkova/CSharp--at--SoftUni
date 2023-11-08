using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.ClassBoxData
{
	public class Box
	{
		private double length;
		private double height;
		private double width;
		public Box (double length, double width, double height)
		{
			Length = length;
			Width = width;
			Height = height;
		}

		public double Length
		{
			get { return this.length;}
			private set{
				if (value <= 0)
				{
					throw new ArgumentException("Length cannot be zero or negative.");
				}
				this.length = value;
			}
		}
		public double Width
		{
			get { return this.width; }
			private set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Width cannot be zero or negative.");
				}
				this.width = value;
			}
		}
		public double Height
		{
			get { return this.height; }
			private set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Height cannot be zero or negative.");
				}
				this.height = value;
			}
		}
	}
}
