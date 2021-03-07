using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int currentClass = 1;
            double sumOfGrades = 0;
            double averageGrade = 0;

            while (currentClass <=12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >=4)
                {
                    sumOfGrades += grade;
                    currentClass++;
                }
            }
            averageGrade = sumOfGrades / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
