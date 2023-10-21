﻿

namespace VendingSystem
{
    public class Drink
    {
	    public Drink(string name, decimal price, int volume)
	    {
		    this.Name = name;
			this.Price = price;
			this.Volume = volume;
	    }
	    public string Name { get; set; }
	    public decimal Price { get; set; }

	    public int Volume { get; set; }

	    public override string ToString()
	    {
		    return $"Name: {this.Name}, Price: ${this.Price}, Volume: {this.Volume} ml";

	    }
    }
}
