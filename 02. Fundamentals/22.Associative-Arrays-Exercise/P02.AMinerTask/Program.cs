namespace P02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string resource = string.Empty;
            Dictionary<string,int> ressourceByQuantity = new Dictionary<string,int>();
           while ((resource = Console.ReadLine()) != "stop")
           {
                int quantity = int.Parse(Console.ReadLine());
                if (!ressourceByQuantity.ContainsKey(resource))
                {
                    ressourceByQuantity.Add(resource, 0);
                }
                ressourceByQuantity[resource]+=quantity;
           }

           foreach (var ressource in ressourceByQuantity)
           {
               Console.WriteLine($"{ressource.Key} -> {ressource.Value}");
           }
        }
    }
}