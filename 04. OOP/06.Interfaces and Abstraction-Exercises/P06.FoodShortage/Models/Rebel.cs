using P05.BirthdayCelebrations.Models.Interfaces;
using P06.FoodShortage.Models.Interfaces;

namespace P06.FoodShortage.Models
{
    public class Rebel :  IAge, IBuyer
    {
	    public Rebel(string name, int age, string group)
	    {
            Name=name;
            Age=age;
            Group=group;
	    }

        public string Group { get; private set; }
        public int Age { get; private set; }
        public string Name { get; private set; }

		public int Food
		{ get; private set; }

		public int BuyFood()
		{
			this.Food += 5;
			return 5; 
		}
	}
}
