
namespace P07.VehicleCatalogue
{
     class Program
    {
        static void Main(string[] args)
        {
            string input;
            Catalog catalogue = new Catalog();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] information = input.Split('/').ToArray();

                string vehicleType = information[0];

                switch (vehicleType)
                {
                    case "Car":
                        Car car = new Car
                        {
                            Brand = information[1],
                            Model = information[2],
                            HorsePower = int.Parse(information[3]),
                        };
                        catalogue.Cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck
                        {
                            Brand = information[1],
                            Model = information[2],
                            Weight = int.Parse(information[3]),
                        };
                        catalogue.Trucks.Add(truck);
                        break;
                }
             }

            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCars = catalogue.Cars.OrderBy(c => c.Brand).ToList();
                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTrucks = catalogue.Trucks.OrderBy(t => t.Brand).ToList();
                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

     class Catalog
     {
         public Catalog()
        {
        this.Cars = new List<Car>();
        this.Trucks = new List<Truck>();

        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
     class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public int Weight { get; set; }

    }
     class Car
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; } 
    }
}