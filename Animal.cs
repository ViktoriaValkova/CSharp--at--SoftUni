namespace Animals
{
    public abstract class Animal
    {

        public Animal(string name, int age, string gender)
        {
            this.Age = age;
            this.Name=name;
            this.Gender=gender;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Gender { get; set;}

        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{this.GetType().Name}\n\r{this.Name} {this.Age} {this.Gender}\n\r{this.ProduceSound()}";
        }
    }
}