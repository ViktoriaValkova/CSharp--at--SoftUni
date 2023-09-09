namespace P08.SoftUniParty
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string reservation = string.Empty;
			Dictionary<string, List<string>> guestsByNum = new Dictionary<string, List<string>>();
			guestsByNum["vip"] = new List<string>();
			guestsByNum["reg"] = new List<string>(); 
			while ((reservation = Console.ReadLine())!="PARTY")
			{
				if (char.IsDigit(reservation[0]))
				{
					guestsByNum["vip"].Add(reservation);
				}
				else
				{
					guestsByNum["reg"].Add(reservation);
				}
			}
			string guestComming = string.Empty;
			while ((guestComming = Console.ReadLine()) != "END")
			{
				if (guestsByNum["vip"].Contains(guestComming))
				{
					guestsByNum["vip"].Remove(guestComming);
				}
				else if (guestsByNum["reg"].Contains(guestComming))
				{
					guestsByNum["reg"].Remove(guestComming);
				}
			}

			Console.WriteLine(guestsByNum["vip"].Count+ guestsByNum["reg"].Count);
			foreach (string guest in guestsByNum["vip"])
			{
				Console.WriteLine(guest);
			}
			foreach (string guest in guestsByNum["reg"])
			{
				Console.WriteLine(guest);
			}
		}
	}
}