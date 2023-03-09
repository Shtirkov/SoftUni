namespace DateModifier
{
    public class DateModifier
    {
        public int DaysDifference { get; set; }

        public void CalculateDaysDifference(string firstDate, string secondDate)
        {
            var firstDateParsed = DateTime.Parse(firstDate);
            var secondDateParsed = DateTime.Parse(secondDate);

            DaysDifference = Math.Abs((int)(secondDateParsed - firstDateParsed).TotalDays);
        }
    }
}
