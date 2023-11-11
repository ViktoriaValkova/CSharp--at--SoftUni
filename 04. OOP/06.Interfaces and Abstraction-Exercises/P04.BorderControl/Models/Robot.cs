using P04.BorderControl.Models.Interfaces;

namespace P04.BorderControl.Models
{
	public class Robot : IIdentifiable
	{
		public string Id { get; private set; }

		public string Name { get; private set; }

		public Robot (string id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}
