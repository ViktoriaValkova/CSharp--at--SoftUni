namespace ClothesMagazine
{
    public class Magazine
    {

	    public Magazine(string type, int capacity)
	    {
            this.Type= type;
            this.Capacity= capacity;
            this.Clothes = new List<Cloth>();
	    }
	    public List<Cloth> Clothes { get; set; }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int GetClothCount () => this.Clothes.Count;

        public void AddCloth(Cloth cloth)
        {
	        if (this.Clothes.Count < this.Capacity)
	        {
		        this.Clothes.Add(cloth); 
	        }
        }

        public bool RemoveCloth(string color)
        {
	        Cloth clothToRemove = this.Clothes.Find(c => c.Color == color);

	        if (clothToRemove != null)
	        {
		        this.Clothes.Remove(clothToRemove);
                return true;
	        }
            return false;
        }

        public Cloth GetSmallestCloth()
        {
	        return this.Clothes.MinBy(c => c.Size);
        }

        public Cloth GetCloth(string color)
        {
	       return this.Clothes.Find(c => c.Color == color);
        }

        public string Report()
        {
	        return $"{this.Type} magazine contains:\n{string.Join("\n", this.Clothes.OrderBy(c => c.Size))}";
        }
    }
}
