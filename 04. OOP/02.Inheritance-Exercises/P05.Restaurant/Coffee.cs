namespace Restaurant
{
    public class Coffee : HotBeverage
    {

        private const double _milliliters = 50;
        private const decimal _price = 3.5m;

        public Coffee(string name, double caffeine) : base(name, _price, _milliliters)
        {
            this.Caffeine = caffeine;
        }
        public double Caffeine { get; set; }

    }
}