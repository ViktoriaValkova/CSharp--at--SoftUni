namespace P03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PianoPiece> pieces = new List<PianoPiece>();

            FillInitialCollection(pieces);

            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdArg = input.Split('|');
                PianoPiece currentPiece = pieces.FirstOrDefault(p => p.Name == cmdArg[1]);
                switch (cmdArg[0])
                {
                    case "Add":
                        AddPiece(pieces, currentPiece, cmdArg);
                        break;
                    case "Remove":
                        RemovePiece(pieces, currentPiece, cmdArg);
                        break;
                    case "ChangeKey":
                        ChangeKey(pieces, currentPiece, cmdArg);
                        break;
                }
            }

            foreach (PianoPiece piece in pieces)
            {
                Console.WriteLine(piece);
            }
        }

        static void AddPiece(List<PianoPiece> pieces, PianoPiece currentPiece, string[] cmdArg)
        {
            if (currentPiece != null)
            {
                Console.WriteLine($"{currentPiece.Name} is already in the collection!");
            }
            else
            {
                pieces.Add(new PianoPiece(cmdArg[1], cmdArg[2], cmdArg[3]));
                Console.WriteLine($"{cmdArg[1]} by {cmdArg[2]} in {cmdArg[3]} added to the collection!");
            }
        }

        private static void RemovePiece(List<PianoPiece> pieces, PianoPiece currentPiece, string[] cmdArg)
        {
            if (currentPiece == null)
            {
                Console.WriteLine($"Invalid operation! {cmdArg[1]} does not exist in the collection.");
            }
            else
            {
                pieces.Remove(currentPiece);
                Console.WriteLine($"Successfully removed {currentPiece.Name}!");
            }
        }

        static void ChangeKey(List<PianoPiece> pieces, PianoPiece currentPiece, string[] cmdArg)
        {
            if (currentPiece == null)
            {
                Console.WriteLine($"Invalid operation! {cmdArg[1]} does not exist in the collection.");
            }
            else
            {
                currentPiece.Key = cmdArg[2];
                Console.WriteLine($"Changed the key of {currentPiece.Name} to {currentPiece.Key}!");
            }
        }

        private static void FillInitialCollection(List<PianoPiece> pieces)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] songInfo = Console.ReadLine().Split('|');
                pieces.Add(new PianoPiece(songInfo[0], songInfo[1], songInfo[2]));
            }
        }
    }

    class PianoPiece
    {
        public PianoPiece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }

        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

        public override string ToString()
        {
            return $"{this.Name} -> Composer: {this.Composer}, Key: {this.Key}";
        }
    }
}
