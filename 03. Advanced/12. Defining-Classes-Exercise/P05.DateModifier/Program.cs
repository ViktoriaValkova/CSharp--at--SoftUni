namespace DateModifier
{
	public class Program
	{
		static void Main(string[] args)
		{
			string firstDate = Console.ReadLine();
			string secondDate = Console.ReadLine();

			DateTime first = DateTime.Parse(secondDate);
			DateTime second = DateTime.Parse(firstDate);

			int result = DateModifier.GetDiff(first, second);
			Console.WriteLine(result);
		}
	}

	public static class DateModifier
	{

		public static int GetDiff(DateTime first, DateTime second)
		{
			TimeSpan diff = first - second;
			int days = diff.Days;

			return Math.Abs(days);
		}
	}

}