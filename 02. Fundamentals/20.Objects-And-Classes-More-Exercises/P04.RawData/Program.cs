namespace P04.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine()); 

            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split();

                string model = data[0];
                int engineSpeed = int.Parse(data[1]);
                int engineWeight = int.Parse(data[2]);
                int cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];

                cars.Add(new Car(model,engineSpeed,engineWeight,cargoWeight,cargoType));
            }
            string command = Console.ReadLine();
            List<Car> carsToPrint = new List<Car>();
            if (command == "fragile")
            {
                 carsToPrint = cars.Where(x=> x.Cargo.Type == "fragile" && x.Cargo.Weight <1000).ToList();
            }
            else
            {
                carsToPrint = cars.Where(x=>x.Cargo.Type == "flamable" && x.Engine.Power>250).ToList();
            }

            foreach (Car car in carsToPrint)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
    class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
        public int Speed { get; set; }

        public int Power { get; set; }

    }
    class Cargo
    {
        public Cargo (int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }

        public string Type { get; set; }
    }
    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }
    }
}