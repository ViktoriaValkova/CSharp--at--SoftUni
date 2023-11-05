namespace Restaurant
{
    public class Cake : Dessert
    {

        private const double _calories = 1000;
        private const decimal _price = 5m;
        private const double _grams = 250;
        public Cake(string name) : base(name, _price, _grams, _calories)
        {

        }

    }
}