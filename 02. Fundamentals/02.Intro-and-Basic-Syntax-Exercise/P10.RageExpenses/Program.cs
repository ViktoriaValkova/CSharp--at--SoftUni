namespace P10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine()!);
            float headsetPrice = float.Parse(Console.ReadLine()!);
            float mousePrice = float.Parse(Console.ReadLine()!);
            float keyboardPrice = float.Parse(Console.ReadLine()!);
            float displayPrice = float.Parse(Console.ReadLine()!);
            double headsetCost = (lostGames / 2) * headsetPrice ; 
            double mouseCost = (lostGames / 3) * mousePrice ;
            double keyboardCost = (lostGames /6)* keyboardPrice ;
            double displayCost = (lostGames/ 12) * displayPrice;
            double total = headsetCost + mouseCost + keyboardCost + displayCost;
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}