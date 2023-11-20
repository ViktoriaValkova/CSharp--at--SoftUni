namespace Animals
{
	public class Animal
	{
		private string _name;
		private string _favoriteFood;

		public Animal(string name, string food)
		{
			Name = name;
			FavoriteFood = food;
		}

		public string Name
		{
			get { return _name; }
			protected set { this._name = value; }
		}
		public string FavoriteFood
		{
			get { return _favoriteFood; }
			protected set { this._favoriteFood = value; }
		}
		public virtual string ExplainSelf()
		{
			return $"I am {_name} and my favourite food is {_favoriteFood}";
		}
	}
}
