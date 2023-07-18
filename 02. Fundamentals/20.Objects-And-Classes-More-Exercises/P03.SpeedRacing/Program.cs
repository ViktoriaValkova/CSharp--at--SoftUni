namespace P03.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split();

                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelPer100km = double.Parse(data[2])*100;

                cars.Add(new Car(model,fuelAmount,fuelPer100km));
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] newData = input.Split();
                string model = newData[1];
                int distance = int.Parse(newData[2]);

                Car currentCar = cars.Find(c => c.Model == model);

                if (currentCar.MoveCar(currentCar, distance))
                {
                    currentCar.TravelledDIstance += distance;
                    currentCar.FuelAmmount -= (currentCar.FuelPer100km * distance)/100;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmmount:f2} {car.TravelledDIstance}");
            }
        }
    }
    class Car
    {
        public Car(string model, double fuelAmmount, double fuelPer100km)
        {
            Model = model;
            FuelAmmount = fuelAmmount;
            FuelPer100km = fuelPer100km;
        }

        public string Model { get; set; }

        public double FuelAmmount { get; set; }

        public double FuelPer100km { get; set; }

        public int TravelledDIstance { get; set; }

        public bool MoveCar(Car currentCar, int distance)
        {
            
            if ((currentCar.FuelAmmount*100)/currentCar.FuelPer100km >= distance)
            {
                return true;
            }
            return false;
        }
    }
}