using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.PizzaCalories.Models
{
	internal class Topping
	{
		private readonly Dictionary<string, double> toppingTypeDict;

		private string type;
		private double grams;
		private double baseCalories = 2;

		public Topping(string type, double grams)
		{
			toppingTypeDict = new Dictionary<string, double>
			{
				{ "meat", 1.2 },
				{ "veggies", 0.8 },
				{ "cheese", 1.1 },
				{ "sauce", 0.9 },
			};
			Type= type;
			Grams= grams;
		}

		public double Calories => CalculateCalories();
		private string Type
		{
			get => type;
			set
			{
				if (!toppingTypeDict.ContainsKey(value.ToLower()))
				{
					throw new ArgumentException($"Cannot place {value} on top of your pizza.");
				}
				type= value;
			}
		}
		private double Grams
		{
			get => grams;
			set
			{
				if (value < 1 || value > 50)
				{
					throw new ArgumentException($"{Type} weight should be in the range [1..50].");
				}
				grams = value;
			}
		}

		private double CalculateCalories()
		{
			double typeModifier = toppingTypeDict[Type.ToLower()];
			return Grams * baseCalories* typeModifier;
		}
	}
}
