namespace P03.Telephony.Models
{
	public class Smartphone : IPhone
	{
		public void CallOtherPhone(string number)
		{
			Console.WriteLine($"Calling... {number}");
		}

		public void BrowseInternet(string url)
		{
			Console.WriteLine($"Browsing: {url}!");
		}
	}
}
