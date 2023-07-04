namespace P02.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!")
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArg = input.Split();

                string command = cmdArg[0];
                string item = cmdArg[1];

                switch (command)
                {
                    case "Urgent":
                        if (!groceries.Contains(item))
                        {
                            groceries.Insert(0,item);
                        }
                            break;
                    case "Unnecessary":
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                        }
                            break;
                    case "Correct":
                        string newItem = cmdArg[2];
                        if (groceries.Contains(item))
                        {
                            ReplaceItem(groceries, item,newItem);
                        }
                            break;
                    case "Rearrange":
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                            groceries.Add(item);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",groceries));
        }

         static void ReplaceItem(List<string> groceries, string item,string newItem)
        {
            int index = groceries.IndexOf(item);
            groceries.RemoveAt(index);
            groceries.Insert(index,newItem);
        }
    }
}