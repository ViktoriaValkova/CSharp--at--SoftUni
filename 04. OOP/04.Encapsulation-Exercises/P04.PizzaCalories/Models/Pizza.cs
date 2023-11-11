using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.PizzaCalories.Models
{
	internal class Pizza
	{
		private string name;
		private readonly List<Topping> toppings;
		private Dough dough;

		public Pizza(string name, Dough dough)
		{
			Name = name;
			toppings= new List<Topping>();
			Dough = dough;
		}

		private string Name
		{
			get => name;
			set
			{
				if (string.IsNullOrWhiteSpace(value) || value.Length > 15) 
				{
					throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
				}
				name = value;
			}
		}

		private Dough Dough
		{
			get => dough;
			set => dough = value;
		}

		private double TotalCaloriesOfPizza => TotalCalories();

		public void AddTopping(Topping topping)
		{
				if (toppings.Count >10)
				{
					throw new ArgumentException("Number of toppings should be in range [0..10].");
				}
			toppings.Add(topping);
		}

		public override string ToString()
		{
			return $"{Name} - {TotalCaloriesOfPizza:f2} Calories.";
		}

		private double TotalCalories()
		{
			double toppingCalories = 0;
			foreach (Topping topping in toppings)
			{
				toppingCalories += topping.Calories;
			}

			return toppingCalories+dough.Calories;
		}
	}
}
