namespace P05.Orders.SecondVersion
{
     class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] order = input.Split();
                string productName = order[0];
                double productPrice = double.Parse(order[1]);
                int quantity = int.Parse(order[2]);

                if (!products.ContainsKey(productName))
                {
                    products[productName] = new Product(productName, productPrice,quantity);
                }
                else
                {
                    Product currentProduct = products[productName];
                    currentProduct.UpdateProduct(quantity,productPrice);
                }
            }

            foreach (Product product in products.Values)
            {
                Console.WriteLine(product);
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

        public double TotalPrice => Price * Quantity;

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public void UpdateProduct(int quantity,double price)
        {
            Price = price;
            Quantity += quantity; 
        }

        public override string ToString()
        {
            return $"{this.Name} -> {this.TotalPrice:f2}";
        }
    }
}