namespace CarManufacturer
{
	 public class Car
	 {

		 public Car(string model, int power, int speed, int weight, string type,
			double pressure1, int age1, double pressure2, int age2, double pressure3, int age3, double pressure4, int age4)

		 {
			 this.Model = model;
			 this.Engine = new(power,speed);
			 this.Cargo = new(weight,type);
			 this.Tires = new Tire[4];
			this.Tires[0] = new(pressure1,age1);
			this.Tires[1] = new(pressure2,age2);
			this.Tires[2] = new(pressure3,age3);
			this.Tires[3] = new(pressure4,age4);
				
		 }


		 private string model;
		 private Engine engine;
		 private Cargo cargo;
		 private Tire[] tires;

		public string Model
		{
			get { return this.model; }
			set { this.model = value; }
		}

		public Cargo Cargo
		{
			get { return this.cargo; }
			set { this.cargo = value; }
		}
		public Engine Engine
		{
			get { return this.engine; }
			set { this.engine = value; }
		}
		public Tire[] Tires 
		{
			get { return this.tires; }
			set { this.tires = value; }
		}

		public static List<Car> FragileCars(List<Car> cars) // can be done with Select to get an [] of the models only 
		{
			List<Car> desiredCars = cars.Where(c => (c.Cargo.Type == "fragile") && c.Tires.Any(t => t.Pressure<1))
				.ToList();

			return desiredCars;
		}
		public static List<Car> FlammabaleCars(List<Car> cars)
		{
			List<Car> desiredCars = cars.Where(c => (c.Cargo.Type == "flammable") && c.Engine.Power>250).ToList();

			return desiredCars;
		}
		public override string ToString()
		{
			return this.Model;
		}
	 }
}
