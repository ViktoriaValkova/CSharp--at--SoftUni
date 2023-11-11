namespace P03.Telephony.Models
{
	public class StationaryPhone : IPhone
	{
		public void CallOtherPhone(string number)
		{
			Console.WriteLine($"Dialing... {number}");
		}
	}
}
