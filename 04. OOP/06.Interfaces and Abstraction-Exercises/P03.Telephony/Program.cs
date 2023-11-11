using P03.Telephony.Models;

namespace P03.Telephony
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] phoneNums = Console.ReadLine().Split();

			string[] websites = Console.ReadLine().Split();

			Smartphone smartPhone = new Smartphone();
			IPhone stationary = new StationaryPhone();

			foreach (var number in phoneNums)
			{
				if (number.Any(ch => !char.IsDigit(ch)))
				{
					Console.WriteLine("Invalid number!");
					continue;
				}
				if (number.Length == 10)
				{
					smartPhone.CallOtherPhone(number);
				}
				else if (number.Length == 7)
				{
					stationary.CallOtherPhone(number);
				}
			}
			foreach (var website in websites)
			{
				if (website.Any(ch => char.IsDigit(ch)))
				{
					Console.WriteLine("Invalid URL!");
					continue;
				}

				smartPhone.BrowseInternet(website);

			}
		}
	}
}