namespace AutomotiveRepairShop
{
    public class RepairShop
    {
	    public RepairShop(int capacity)
	    {
			this.Capacity=capacity;
			this.Vehicles = new List<Vehicle>();
	    }
	    public int Capacity { get; set; }

	    public List<Vehicle> Vehicles { get; set; }

	    public void AddVehicle(Vehicle vehicle)
	    {
		    if (this.Capacity > 0)
		    {
				this.Vehicles.Add(vehicle);
				this.Capacity--;
		    }
	    }

	    public bool RemoveVehicle(string vin)
	    {
		    var foundVehicle = this.Vehicles.Find(v => v.VIN == vin);

		    if (foundVehicle!=null)
		    {
			    this.Vehicles.Remove(foundVehicle);
			    this.Capacity++;
				return true;
		    }

			return false;
	    }

		public int GetCount () => this.Vehicles.Count;

		public Vehicle GetLowestMileage()
		{
			return this.Vehicles.MinBy(v => v.Mileage);
		}

		public string Report()
		{
			return $"Vehicles in the preparatory:\n{string.Join("\n", this.Vehicles)}";
		}
    }
}
