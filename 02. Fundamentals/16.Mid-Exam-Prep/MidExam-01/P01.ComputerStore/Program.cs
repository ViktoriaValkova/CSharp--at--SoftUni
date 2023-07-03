namespace P01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sum = 0;
            while (input != "special" && input != "regular")
            {
                decimal price = decimal.Parse(input);
                if (price == 0)
                {
                    break;
                }
                if (price <= 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    sum += price;
                }

                input = Console.ReadLine();
            }
            decimal totalWithTaxes = sum * 1.2m;
            decimal finalPrice = totalWithTaxes;
            if (input == "special")
            {
                finalPrice *= 0.9m;
            }
            if (finalPrice != 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {totalWithTaxes - sum:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }

        }

    }
}