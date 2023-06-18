namespace P11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine()!);
            double price = 0;
            int days = 0;
            int capsuleCnt = 0;
            double totalPrice = 0;
            for (int i = 0; i < ordersCount; i++)
            {
                price = double.Parse(Console.ReadLine()!); 
                days = int.Parse(Console.ReadLine()!);
                capsuleCnt = int.Parse(Console.ReadLine()!);
                double orderPrice = days * capsuleCnt * price;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                totalPrice += orderPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}