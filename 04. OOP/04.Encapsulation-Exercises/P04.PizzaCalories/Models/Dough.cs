using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.PizzaCalories.Models
{
	internal class Dough
	{
		private readonly Dictionary<string,double> flourTypeDict;
		private readonly Dictionary<string,double> bakingTechniqueDict;

		private string flourType;
		private string bakingTechnique;
		private double grams;
		private double baseCalories = 2;

		public Dough(string flourType, string bakingTechnique, double grams)
		{
			flourTypeDict = new Dictionary<string, double> { { "white", 1.5 }, { "wholegrain", 1.0 } };
			bakingTechniqueDict = new Dictionary<string, double>{ { "crispy", 0.9 }, { "chewy", 1.1 }, {"homemade", 1.0} };
			FlourType = flourType;
			BakingTechnique =bakingTechnique;
			Grams =grams;
		}
		public double Calories => CalculateCaloriesPerGram();

		private string FlourType
		{
			get => flourType;
			 set
			{
				if (flourTypeDict.ContainsKey(value.ToLower()))
				{
					flourType = value.ToLower();
				}
				else
				{
					throw new ArgumentException("Invalid type of dough.");
				}
			}
		}
		private string BakingTechnique
		{
			get => bakingTechnique;
			 set
			{
				if (bakingTechniqueDict.ContainsKey(value.ToLower()))
				{
					bakingTechnique = value.ToLower();
				}
				else
				{
					throw new ArgumentException("Invalid type of dough.");
				}
			}
		}

		private double Grams
		{
			get => grams;
			set
			{
				if (value < 1 || value > 200)
				{
					throw new ArgumentException("Dough weight should be in the range [1..200].");
				}
				grams=value;
			}
		}

		private double CalculateCaloriesPerGram()
		{
			double result = baseCalories * Grams;
			double flourTypeModifier = flourTypeDict[this.FlourType];
			double bakingTechniqueModifier = bakingTechniqueDict[this.BakingTechnique];
			return result * flourTypeModifier * bakingTechniqueModifier;
		}
	}
}
