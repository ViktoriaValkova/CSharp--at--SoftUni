namespace P06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            double sumHPCar = 0;
            double sumHPTruck = 0;
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split();
                string type = info[0];
                string model = info[1];
                string color = info[2];
                int horsePower = int.Parse(info[3]);
                if (type == "car")
                {
                    Car car = new Car(model, color, horsePower);
                    cars.Add(car);
                    sumHPCar += horsePower;
                }
                else
                {
                    Truck truck = new Truck(model, color, horsePower);
                    trucks.Add(truck);
                    sumHPTruck += horsePower;
                }
            }

            string secondInput; 
            while ((secondInput = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Car car in cars)
                {
                    if (secondInput == car.Model)
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                        break;
                    }
                }
                foreach (Truck truck in trucks)
                {
                    if (secondInput == truck.Model)
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                        break;
                    }
                }
            }
            if (cars.Count > 0)
            {
                double averageHPCars = sumHPCar / cars.Count;
                Console.WriteLine($"Cars have average horsepower of: {averageHPCars:f2}.");
            }
            else
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }

            if (trucks.Count > 0)
            {
                double averageHPTrucks = sumHPTruck / trucks.Count;
            Console.WriteLine($"Trucks have average horsepower of: {averageHPTrucks:f2}.");
            }
            else
            {
            Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }

        }
    }
    class Truck
    {
        public Truck(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Model { get; set; }
        public string Color { get; set; }

        public int HorsePower { get; set; }
    }
    class Car
    {
        public Car(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }

        public int HorsePower { get; set; }
    }
}