namespace P06.FoodShortage.Models.Interfaces
{
	public interface IBuyer
	{
		public string Name { get; }
		public int Food { get; }
		public int BuyFood();
	}
}
