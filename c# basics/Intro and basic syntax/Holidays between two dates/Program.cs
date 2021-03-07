using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

        var holidaysCount = 0;

        for (var date = startDate; date <= endDate; date.AddDays(1.0))
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }        
        Console.WriteLine(holidaysCount);
    }
}