namespace P03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string game = string.Empty;
            double price = 0;
            double sumSpent = 0;
           
            while ((game = Console.ReadLine()) != "Game Time")
            {
                 bool notValid = false;
                switch (game)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        notValid = true;
                        break;
                }
                if (!notValid)
                {

                    if (balance >= price)
                    {
                        balance -= price;
                        Console.WriteLine($"Bought {game}");
                        sumSpent += price;
                    }
                    else if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
            }
            if (game == "Game Time")
            {
                if (balance > 0)
                {
                    Console.WriteLine($"Total spent: ${sumSpent:f2}. Remaining: ${balance:f2}");
                }
            }
        }
    }
}