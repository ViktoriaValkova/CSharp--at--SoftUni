namespace P03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>items=Console.ReadLine()
                .Split(", ")
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] cmdArg = input
                    .Split(new string [] {":"," - "," "},StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArg[0];
                if (command == "Collect")
                {
                    CollectItem(items, cmdArg[1]);
                }
                else if (command == "Drop")
                {
                    DropItem (items, cmdArg[1]);
                }
                else if (command == "Renew")
                {
                    RenewList (items, cmdArg[1]);
                }
                else //combine
                {
                    CombineItems (items, cmdArg[2], cmdArg[3]);
                }
            }

            Console.WriteLine(string.Join(", ",items));
        }

        static void CollectItem(List<string> items, string currentItem)
        {
           if (!items.Contains(currentItem))
           {
                items.Add(currentItem);
           }
        }
        static void DropItem(List<string> items, string currentItem)
        {
           if (items.Contains(currentItem))
            {
                items.Remove(currentItem);
            }
        }
         static void CombineItems(List<string> items, string oldItem, string newItem)
        {
            if (items.Contains(oldItem))
            {
                int index = items.IndexOf(oldItem);
                items.Insert(index+1, newItem);
            }
        }
        static void RenewList(List<string> items, string currentItem)
        {
            if(items.Contains(currentItem))
            {
                items.Remove(currentItem);
                items.Add(currentItem);
            }
        }



    }
}
