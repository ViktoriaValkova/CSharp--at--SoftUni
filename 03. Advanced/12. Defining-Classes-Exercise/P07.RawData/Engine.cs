
namespace CarManufacturer
{
	public class Engine
	{

		public Engine(int power, int speed)
		{
			this.Power = power;
			this.Speed = speed;
		}
		private int speed;
		private int power;


		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}

		public int Power
		{
			get { return power; }
			set { power = value; }
		}


	}

}

