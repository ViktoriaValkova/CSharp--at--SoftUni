﻿namespace CarManufacturer
{
	public class Car
	{
		public Car()
		{
			this.Make = "VW";
			this.Model = "Golf";
			this.Year = 2025;
			this.FuelQuantity = 200;
			this.FuelConsumption = 10;
		}

		public Car(string make, string model, int year)
		: this() // calling the other constructor
		{
			this.Make = make;
			this.Model = model;
			this.Year = year;
		}

		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
			: this(make, model, year)
		{
			this.FuelQuantity = fuelQuantity;
			this.FuelConsumption = fuelConsumption;
		}

		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
			: this(make, model, year, fuelQuantity, fuelConsumption)
		{
			this.Engine = engine;
			this.Tires = tires;
		}

		private string make;
		private string model;
		private int year;
		private double fuelQuantity;
		private double fuelConsumption;
		private Engine engine;
		private Tire[] tires;

		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }

		public double FuelQuantity { get; set; }
		public double FuelConsumption { get; set; }

		public Engine Engine { get; set; }
		public Tire[] Tires { get; set; }

		public double SumTirePressure (Tire[] Tires)
		{
			double sum = 0;
			foreach (Tire t in this.Tires)
			{
				sum += t.Pressure;
			}
			return sum; 
		}

		public void Drive(double distance)
		{
			if (distance * this.FuelConsumption/100.0 < this.FuelQuantity)
			{
				this.FuelQuantity -= distance * this.FuelConsumption/100;
			}
			else
			{
				Console.WriteLine("Not enough fuel to perform this trip!");
			}
		}


		public string WhoAmI()
		{
			return $"Make: {this.Make}\n" +
			       $"Model: {this.Model}\n" +
			       $"Year: {this.Year}\n" +
			       $"HorsePowers: {this.Engine.HorsePower}\n" +
			       $"FuelQuantity: {this.FuelQuantity}";

		}
	}
}
