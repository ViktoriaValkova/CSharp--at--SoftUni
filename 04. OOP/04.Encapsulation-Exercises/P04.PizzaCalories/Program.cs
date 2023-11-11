using P04.PizzaCalories.Models;

namespace P04.PizzaCalories
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string[] pizzaInfo = Console.ReadLine().Split();
				string[] doughInfo = Console.ReadLine().Split();

				string flourType = doughInfo[1];
				string bakingTechnique = doughInfo[2];
				double doughGrams = double.Parse(doughInfo[3]);
				Dough dough = new Dough(flourType, bakingTechnique, doughGrams);

				string pizzaName = pizzaInfo[1];
				Pizza pizza = new Pizza(pizzaName, dough);

				string input = string.Empty;

				while ((input = Console.ReadLine()) != "END")
				{
					string[] toppingInfo = input.Split(" ");
					string toppingType = toppingInfo[1];
					double toppingGrams = double.Parse(toppingInfo[2]);
					Topping topping = new Topping(toppingType, toppingGrams);
					pizza.AddTopping(topping);
				}
				Console.WriteLine(pizza);
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}

		}
	}
}