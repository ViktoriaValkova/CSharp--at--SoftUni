namespace P06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] information = input.Split();

                Box box = new Box
                {
                    SerialNumber = information[0],
                    Item  = new Item (information[1], decimal.Parse(information[3])),
                    ItemQuantity = int.Parse(information[2]),
                };
                boxes.Add(box);
            }
          List<Box> sortedList = boxes.OrderByDescending(box => box.PricePerBox).ToList();
          foreach (Box box in sortedList)
          {
              Console.WriteLine(box.SerialNumber);
              Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
              Console.WriteLine($"-- ${box.PricePerBox:f2}");
          }
        }
    }
    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }

        // public decimal PricePerBox
        // {
        //     get
        //     {
        //         return this.ItemQuantity * this.Item.Price;
        //     }

        // }

        public decimal PricePerBox => this.ItemQuantity*this.Item.Price; 
    }
}