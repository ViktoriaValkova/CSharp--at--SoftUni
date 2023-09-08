namespace P04.ProductShop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Dictionary<string, double>> productsByShop =
				new Dictionary<string, Dictionary<string, double>>();

			string input = string.Empty;

			while ((input = Console.ReadLine()) != "Revision")
			{
				string[] info = input.Split(", "); 

				string shopName = info[0];
				string productName = info[1];
				double price = double.Parse(info[2]);

				if (!productsByShop.ContainsKey(shopName))
				{
					productsByShop[shopName] = new Dictionary<string, double>();
				}

				if (!productsByShop[shopName].ContainsKey(productName))
				{
					productsByShop[shopName][productName] = 0;
				}
				productsByShop[shopName][productName] = price;
			}

			var orderedShops = productsByShop.OrderBy(x => x.Key);

			foreach (var kvp in orderedShops)
			{
				Console.WriteLine($"{kvp.Key} -> ");
				var products = kvp.Value;

				foreach (var product in products)
				{
					Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
				}
			}
		}
	}
}