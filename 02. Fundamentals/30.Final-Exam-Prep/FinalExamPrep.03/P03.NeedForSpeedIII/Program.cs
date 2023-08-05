using System.Collections.Generic;

namespace P03.NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int countCars = int.Parse(Console.ReadLine());
            FillCarPark(countCars, cars);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdArg = input.Split(" : ").ToArray();
                Car currentCar = cars.FirstOrDefault(c => c.Brand == cmdArg[1]);
                switch (cmdArg[0])
                {
                    case "Drive":
                        DriveCar(cars, currentCar, int.Parse(cmdArg[2]), int.Parse(cmdArg[3]));
                        break;
                    case "Refuel":
                        RefuelCar(currentCar, int.Parse(cmdArg[2]));
                        break;
                    case "Revert":
                        DecreaseMileage(currentCar, int.Parse(cmdArg[2]));
                        break;
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }

        static void FillCarPark(int countCars, List<Car> cars)
        {
            for (int i = 0; i < countCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split('|');
                string brand = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);
                cars.Add(new Car(brand, mileage, fuel));
            }
        }
        static void DriveCar(List<Car> cars, Car currentCar, int distance, int fuel)
        {
            if (currentCar.Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                currentCar.Fuel -= fuel;
                currentCar.Mileage += distance;
                Console.WriteLine($"{currentCar.Brand} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
            }
            if (currentCar.Mileage >= 100_000)
            {
                Console.WriteLine($"Time to sell the {currentCar.Brand}!");
                cars.Remove(currentCar);
            }
        }
        static void RefuelCar(Car currentCar, int fuel)
        {
            int nettoFuel = fuel;
            if (currentCar.Fuel + fuel > 75)
            {
                nettoFuel = 75 - currentCar.Fuel;
                currentCar.Fuel = 75;
            }
            else
            {
                currentCar.Fuel += fuel;
            }

            Console.WriteLine($"{currentCar.Brand} refueled with {nettoFuel} liters");
        }
        static void DecreaseMileage(Car currentCar, int kilometers)
        {
            currentCar.Mileage -= kilometers;
            if (currentCar.Mileage < 10_000)
            {
                currentCar.Mileage = 10_000;
            }
            else
            {
                Console.WriteLine($"{currentCar.Brand} mileage decreased by {kilometers} kilometers");
            }
        }
    }
    class Car
    {
        public Car(string brand, int mileage, int fuel)
        {
            Brand = brand;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string Brand { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }

        public override string ToString()
        {
            return $"{this.Brand} -> Mileage: {this.Mileage} kms, Fuel in the tank: {this.Fuel} lt.";
        }
    }
}