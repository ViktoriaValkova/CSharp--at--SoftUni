namespace P07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double sum = 0;
            while ((input = Console.ReadLine()!) != "Start")
            {
                double coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }
            string product = string.Empty;
            while ((product = Console.ReadLine()!) != "End")
            {
                double price = 0;
                switch (product)
                {
                    case "Nuts": price = 2.0; break;
                    case "Water": price = 0.7; break;
                    case "Crisps": price = 1.5; break;
                    case "Soda": price = 0.8; break;
                    case "Coke": price = 1; break;
                    default:
                        Console.WriteLine("Invalid product"); break;
                }
                if (sum >= price && price != 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sum -= price;
                }
                else if (sum < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            if (product == "End")
            {
                Console.WriteLine($"Change: {sum:f2}");
            }
        }
    }
}