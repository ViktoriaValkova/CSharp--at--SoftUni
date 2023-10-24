namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Child> Registry { get; set; }

        public Kindergarten(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Registry = new List<Child>();
        }

        public int ChildrenCount => this.Registry.Count;


        public bool AddChild(Child child)
        {
	        if (this.Capacity > 0)
	        {
                this.Registry.Add(child);
                this.Capacity--;
                return true;
	        }

            return false;
        }

        public bool RemoveChild(string fullName)
        {
	        Child founChild = this.Registry.Find(c => c.FullName == fullName);
	        if (founChild != null)
	        {
		        this.Registry.Remove(founChild);
		        this.Capacity++;
                return true;
	        }

	        return false;
        }

        public Child GetChild(string fullName)
        {
	        Child founChild = this.Registry.Find(c => c.FullName == fullName);
	        return founChild; 
        }

        public string RegistryReport()
        {
            this.Registry.Sort();
	        string result = $"Registered children in {this.Name}:\n";
	        result += string.Join("\n", this.Registry);

	        return result;
        }
    }
}
