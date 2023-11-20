
namespace Shapes
{
	public class Circle : Shape
	{
		private double radius;

		public Circle(double radius)
		{
			Radius=radius;
		}

		public double Radius
		{
			get { return this.radius; }
			private set { this.radius = value; }
		}
		public override double CalculatePerimeter()
		{
			return 2 * radius * Math.PI;
		}

		public override double CalculateArea()
		{
			return Math.PI*radius * radius;
		}

		public override string Draw()
		{
			return base.Draw()+ this.GetType().Name;
		}
	}
}
