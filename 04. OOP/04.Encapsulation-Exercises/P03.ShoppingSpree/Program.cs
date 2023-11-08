namespace P03.ShoppingSpree
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] people = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
			string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
			List<Person> peopleList = new List<Person>();
			List<Product>productList  = new List<Product>();

			if (!FillPeopleList(people, peopleList) || !FillProductList(products, productList))
			{
				return;
			}

			BuyProducts(peopleList, productList);

			PrintPeopleProductInfo(peopleList);
		}

		private static void PrintPeopleProductInfo(List<Person> peopleList)
		{
			foreach (Person person in peopleList)
			{
				Console.Write($"{person.Name} - ");
				if (person.Products.Count > 0)
				{
					List<string> currentList = person.Products.ConvertAll(p=>p.Name).ToList();
					Console.WriteLine(string.Join(", ", currentList));
				}
				else
				{
					Console.WriteLine("Nothing bought");
				}
			}
		}

		private static void BuyProducts(List<Person> peopleList, List<Product> productList)
		{
			string input = string.Empty;
			while ((input = Console.ReadLine()) != "END")
			{
				string[] cmdArg = input.Split();
				string personName = cmdArg[0];
				string productName = cmdArg[1];

				Person currentPerson = peopleList.Find(p => p.Name == personName);
				Product currentProduct = productList.Find(p => p.Name == productName);
				if (currentPerson.Money >= currentProduct.Cost)
				{
					currentPerson.Products.Add(currentProduct);
					currentPerson.Money -= currentProduct.Cost;
					Console.WriteLine($"{personName} bought {productName}");
				}

				else
				{
					Console.WriteLine($"{personName} can't afford {productName}");
				}
			}
		}

		private static bool FillProductList(string[] products, List<Product> productList)
		{
			foreach (string product in products)
			{
				try
				{
					string[] productInfo = product.Split("=", StringSplitOptions.RemoveEmptyEntries);
					string name = productInfo[0];
					int cost = int.Parse(productInfo[1]);
					Product currentProduct = new Product(name, cost);
					productList.Add(currentProduct);
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
					return false;
				}
			}

			return true;
		}

		private static bool FillPeopleList(string[] people, List<Person> peopleList)
		{
			foreach (string p in people)
			{
				try
				{
					string[] personInfo = p.Split("=", StringSplitOptions.RemoveEmptyEntries);
					string name = personInfo[0];
					int money = int.Parse(personInfo[1]);
					Person person = new Person(name, money);
					peopleList.Add(person);
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
					return false;
				}
			}

			return true;
		}
	}
}