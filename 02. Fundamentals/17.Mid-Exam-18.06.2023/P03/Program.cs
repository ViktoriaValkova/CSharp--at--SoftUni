namespace P03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> deck = Console.ReadLine().Split(", ").ToList();

            int commandsCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCnt; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(", ").ToArray();

                switch (cmdArg[0])
                {
                    case "Add":
                        Add(deck, cmdArg[1]);
                        break;
                    case "Remove":
                        Remove(deck, cmdArg[1]);
                        break;
                    case "Remove At":
                        RemoveAtIndex(deck, int.Parse(cmdArg[1]));
                        break;
                    case "Insert":
                        InsertAtIndex(deck, int.Parse(cmdArg[1]), cmdArg[2]);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", deck));
        }

        static void Add(List<string> deck, string card)
        {
            if (deck.Contains(card))
            {
                Console.WriteLine("Card is already in the deck");
                return;
            }
            deck.Add(card);
            Console.WriteLine("Card successfully added");
        }

        static void Remove(List<string> deck, string card)
        {
            if (deck.Contains(card))
            {
                deck.Remove(card);
                Console.WriteLine("Card successfully removed");
                return;
            }

            Console.WriteLine("Card not found");
        }

        static void RemoveAtIndex(List<string> deck, int index)
        {
            if (IsIndexValid(deck, index))
            {
                deck.RemoveAt(index);
                Console.WriteLine("Card successfully removed");
            }
        }

        static bool IsIndexValid(List<string> deck, int index)
        {
            if (index >= 0 && index < deck.Count)
            {
                return true;
            }

            Console.WriteLine("Index out of range");
            return false;
        }

        static void InsertAtIndex(List<string> deck, int index, string card)
        {
            if (IsIndexValid(deck, index))
            {
                if (!deck.Contains(card))
                {
                    deck.Insert(index, card);
                    Console.WriteLine("Card successfully added");
                    return;
                }

                Console.WriteLine("Card is already added");
            }
        }
    }
}