﻿namespace CarManufacturer
{
	 class Car
	 {
		 private string make;
		 private string model;
		 private int year;
		 private double fuelQuantity;
		 private double fuelConsumption;

		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }

		public double FuelQuantity { get; set; }
		public double FuelConsumption { get; set; }

		public void Drive(double distance)
		{
			if (distance * this.FuelConsumption < this.FuelQuantity)
			{
				this.FuelQuantity -= distance*this.FuelConsumption;
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
			       $"Fuel: {this.FuelQuantity:f2}";
		}
	}
}
