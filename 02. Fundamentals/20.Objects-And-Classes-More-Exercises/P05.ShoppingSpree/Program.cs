namespace P05.ShoppingSpree
{
     class Program
    {
        static void Main(string[] args)
        {
           
            string[] peopleInfo = Console.ReadLine().Split(";");
            string[] productInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            for (int i = 0; i < peopleInfo.Length; i++)
            {
                string[] currentPerson = peopleInfo[i].Split("="); 
                people.Add(new Person(currentPerson[0], int.Parse(currentPerson[1])));
            }

            for (int i = 0; i < productInfo.Length; i++)
            {
                string[] currentProduct = productInfo[i].Split("=");
                products.Add(new Product(currentProduct[0], int.Parse(currentProduct[1])));
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(); 

                Person person = people.First(p=>p.Name == command[0]);
                Product product = products.Find(p => p.ProductName == command[1]); 
                person.BuyProduct(person,product);
            }

            foreach (Person person in people)
            {
                if (person.BagOfProducts.Count > 0)
                {
                    List<string> thisPersonsProducts = new List<string>();
                    foreach (Product product in person.BagOfProducts)
                    {
                        thisPersonsProducts.Add(product.ProductName);
                    }

                    Console.WriteLine($"{person.Name} - {string.Join(", ", thisPersonsProducts)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }


        }
    }
    class Product
    {
        public Product(string name, int preis)
        {
            ProductName = name;
            ProductPreis = preis;
        }

    public string ProductName  { get; set; }
        public int ProductPreis { get; set; }
    }
    class Person
    {
        public Person(string name, int money)
        {
            Name = name;
            Money = money;
        }
        public string Name { get; set; }
        public int Money { get; set; }

        public List<Product> BagOfProducts = new List<Product>(); // we have to initialize it here, or se other option from Kristiyan. 

        public void BuyProduct(Person person, Product product)
        {
           
            if (person.Money >= product.ProductPreis)
            {
                BagOfProducts.Add(product);  // we put here just the List Propert name, with UpperLetter
                Console.WriteLine($"{person.Name} bought {product.ProductName}");
                person.Money -= product.ProductPreis;
            }
            else
            {
                Console.WriteLine($"{person.Name} can't afford {product.ProductName}");
            }
        }
    }
}