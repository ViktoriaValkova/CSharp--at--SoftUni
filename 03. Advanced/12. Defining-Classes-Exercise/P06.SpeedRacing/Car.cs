
namespace CarCollection
{
	internal class Car
	{

		private string model;
		private double fuelAmount;
		private double fuelConsumptionPerKilometer;
		private double travelledDistance;

		public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
		{
			this.Model = model;
			this.FuelAmount = fuelAmount;
			this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
			this.TravelledDistance = 0;
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public double FuelAmount
		{
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}

		public double FuelConsumptionPerKilometer
		{
			get { return fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }
		}

		public double TravelledDistance
		{
			get { return travelledDistance;}
			set { travelledDistance = value; }
		}

		public void Drive(double distance)
		{
			if (distance * this.FuelConsumptionPerKilometer <= this.FuelAmount)
			{
				this.TravelledDistance += distance;
				this.FuelAmount-= distance*this.FuelConsumptionPerKilometer;
			}
			else
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
		}

		
		public override string ToString()
		{
			return $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
		}
	}
}
