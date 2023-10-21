

using System.Runtime.CompilerServices;

namespace VendingSystem
{
    public class VendingMachine
    {
	    public VendingMachine(int buttonCapacity)
	    {
			this.ButtonCapacity= buttonCapacity;
			this.Drinks = new List<Drink>();
	    }
	    public int ButtonCapacity { get; set; }

	    public List<Drink> Drinks { get; set; }

	    public int GetCount => this.Drinks.Count;

	    public void AddDrink(Drink drink)
	    {
		    if (this.ButtonCapacity > 0)
		    {
			    this.ButtonCapacity--;
				this.Drinks.Add(drink);
		    }
	    }

	    public bool RemoveDrink(string name)
	    {
			Drink drink = this.Drinks.Where(d=>d.Name==name).FirstOrDefault();
		    if (drink!=null)
		    {
				this.Drinks.Remove(drink);
				return true;
		    }
		    return false;
	    }

	    public Drink GetLongest()
	    {
		    return this.Drinks.MaxBy(d => d.Volume);
	    }

	    public Drink GetCheapest()
	    {
		    return this.Drinks.MinBy(d => d.Price);
	    }

	    public string BuyDrink(string name)
	    {
		    Drink drink = this.Drinks.Find(d => d.Name == name);
		    return drink.ToString();
	    }

	    public string Report()
	    {
		    string result = "Drinks available:\n";
		    foreach (var drink in this.Drinks)
		    {
			    result += drink+"\n";
		    }
			return result.Trim();
	    }
    }
}
