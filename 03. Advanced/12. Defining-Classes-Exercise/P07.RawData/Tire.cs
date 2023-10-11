

namespace CarManufacturer
{
	public class Tire
	{
		public Tire(double pressure, int age)
		{
			this.Age = age;
			this.Pressure = pressure;
		}
		private int age;
		private double pressure;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public double Pressure
		{
			get { return pressure;}
			set { pressure = value; }
		}
	}
}
