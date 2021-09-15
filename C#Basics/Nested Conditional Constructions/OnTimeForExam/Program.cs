using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int hourArrived = int.Parse(Console.ReadLine());
            int minuteArrived = int.Parse(Console.ReadLine());
            string result = "";

            if(examMinute >=60 || minuteArrived >= 60)
            {
                examHour = examHour + 1;
                hourArrived = hourArrived + 1;
                examMinute = examMinute - 60;
                minuteArrived = minuteArrived - 60;
            }

            if (examHour > hourArrived && examMinute > minuteArrived)
            {
                result = "Late";
                Console.WriteLine(result);
            }
            else if (examHour > hourArrived && examMinute == minuteArrived)
            {
                result = "Late";
                Console.WriteLine(result);
            }
            else if (examHour > hourArrived && examMinute < minuteArrived)
            {
                result = "Late";
                Console.WriteLine(result);
            }
            else if (examHour == hourArrived && examMinute < minuteArrived)
            {
                result = "Late";
                Console.WriteLine(result);
            }
            else if (examHour == hourArrived && examMinute == minuteArrived)
            {
                result = "On time";
                Console.WriteLine(result);
            }
            else if (examHour == hourArrived && examMinute > minuteArrived)
            {
                if (examMinute + 30 >= minuteArrived)
                {
                    result = "On time";
                    Console.WriteLine(result);
                }
                result = "Early";
                Console.WriteLine(result);
            }
            else if (examHour < hourArrived && examMinute > minuteArrived)
            {
                result = "Early";
                Console.WriteLine(result);
            }
            else if (examHour < hourArrived && examMinute == minuteArrived)
            {
                result = "Early";
                Console.WriteLine(result);
            }
            else if (examHour < hourArrived && examMinute < minuteArrived)
            {
                result = "Early";
                Console.WriteLine(result);
            }
            if (examHour == hourArrived && examMinute > minuteArrived)
            {
                Console.WriteLine($"{examMinute - minuteArrived} minutes before the start");
            }else if(examHour > hourArrived)
            {
                Console.WriteLine($"{examHour - hourArrived}:{examMinute - minuteArrived:f2} hours before the start");
            }
        }
    }
}
