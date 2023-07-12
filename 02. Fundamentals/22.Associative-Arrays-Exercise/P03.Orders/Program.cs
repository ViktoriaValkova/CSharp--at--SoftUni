namespace P03.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Product, double> orders = new Dictionary<Product, double>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] order = input.Split();
                string productName = order[0];
                double productPrice = double.Parse(order[1]);
                int quantity = int.Parse(order[2]);

                Product foundProduct = orders.Keys.FirstOrDefault(o => o.Name == productName);
                if (foundProduct == null)
                {
                    foundProduct = new Product(productName, productPrice, quantity);
                    orders.Add(foundProduct, 0);
                }
                else
                {
                    foundProduct.Price = productPrice; 
                    foundProduct.Quantity += quantity;
                }
                orders[foundProduct] = foundProduct.Price*foundProduct.Quantity;
            }

            foreach (var order in orders)
            {
                Console.WriteLine($"{order.Key.Name} -> {order.Value:f2}");
            }
        }
    }
    class Product
    {
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

    }
}