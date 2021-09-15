using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int currentClass = 1;
            double sumOfGrades = 0;
            int numberOfFails = 0;
            double averageGrade = 0;

            while (currentClass <=12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade>=4)
                {
                    sumOfGrades += grade;
                    currentClass++;
                }
                else if (grade<=4)
                {
                    numberOfFails++;
                }

                if (numberOfFails >1)
                {
                    break;
                }
            }

            if (currentClass < 12)
            {
                Console.WriteLine($"{studentName} has been excluded at {currentClass} grade");
            }
            else
            {
                averageGrade = sumOfGrades / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
