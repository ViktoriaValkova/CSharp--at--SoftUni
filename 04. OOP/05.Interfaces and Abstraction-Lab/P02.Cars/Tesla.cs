﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;

namespace P02.Cars
{
	internal class Tesla : ICar, IElectricCar
	{

		public Tesla(string model, string color, int battery)
		{
			Model= model;
			Color= color;
			Battery= battery;
		}
		public string Model { get; set; }
		public string Color { get; set; }
		public int Battery { get; set; }

		public override string ToString()
		{
			return $"{Color} Tesla {Model} with {Battery} Batteries";
		}
	}
}
