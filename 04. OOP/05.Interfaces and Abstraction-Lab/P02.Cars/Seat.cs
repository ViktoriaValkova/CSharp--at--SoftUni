using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;

namespace P02.Cars
{
	internal class Seat : ICar
	{
		public string Model { get; set; }
		public string Color { get; set; }

		public Seat(string model, string color)
		{
			this.Model = model;
			this.Color = color;
		}
		public override string ToString()
		{
			return $"{this.Color} Seat {this.Model}";
		}
	}
}
