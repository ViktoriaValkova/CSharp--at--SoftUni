namespace P07.ParkingLot
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<string> parking = new HashSet<string>();

			string input = string.Empty;

			while ((input = Console.ReadLine()) != "END")
			{
				string[] carInfo = input.Split(", "); 

				string direction = carInfo[0];
				string numberPlate = carInfo[1];

				if (direction == "IN")
				{
					parking.Add(numberPlate);
				}
				else
				{
					parking.Remove(numberPlate);
				}
			}

			if (parking.Any())
			{
				Console.WriteLine(string.Join("\n", parking));
			}
			else
			{
				Console.WriteLine($"Parking Lot is Empty");
			}
		}
	}
}