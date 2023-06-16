using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
           "d.M.yyyy", CultureInfo.InvariantCulture); // date format
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture); // date format
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1)) // date wasnt being incremented
            if (date.DayOfWeek == DayOfWeek.Saturday && // from and to or 
                date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        Console.WriteLine(holidaysCount);
    }
}
