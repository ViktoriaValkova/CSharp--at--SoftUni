namespace P06.VehicleCatalogue.SecondVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split();
                string type = info[0];
                string model = info[1];
                string color = info[2];
                int horsePower = int.Parse(info[3]);
                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(vehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle currVehicle = vehicles.First(v => v.Model == input);
                if (currVehicle.Type == "car")
                {
                    Console.WriteLine("Type: Car");
                }
                else
                {
                    Console.WriteLine("Type: Truck");
                }
                Console.WriteLine($"Model: {currVehicle.Model}");
                Console.WriteLine($"Color: {currVehicle.Color}");
                Console.WriteLine($"Horsepower: {currVehicle.HorsePower}");
            }

            List<Vehicle> cars = vehicles.Where(v => v.Type == "car").ToList();
            List<Vehicle> trucks = vehicles.Where(v => v.Type == "truck").ToList();

            double totalHPCars = cars.Sum(x => x.HorsePower);
            double totalHPTrucks = trucks.Sum(x => x.HorsePower);

            double averageHPCars = 0.00;
            double averrageHPTrucks = 0.00;

            if (cars.Count > 0)
            {
                 averageHPCars = totalHPCars / cars.Count;
            }

            if (trucks.Count > 0)
            {
                averrageHPTrucks = totalHPTrucks / trucks.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageHPCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averrageHPTrucks:f2}.");
        }


        class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;
            }

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }

            public int HorsePower { get; set; }
        }
    }
}