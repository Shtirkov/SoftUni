using System;

namespace _01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int countOfTheCourseLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double bonusOfTheStudentWithMostAttendedLectures = 0;
            int studentWithMostAttendedLectures = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int countOfstudentsAttendances = int.Parse(Console.ReadLine());

                if (countOfstudentsAttendances > studentWithMostAttendedLectures)
                {
                    studentWithMostAttendedLectures = countOfstudentsAttendances;
                }

                double totalBonus =(double) countOfstudentsAttendances / countOfTheCourseLectures * (5 + additionalBonus);

                if (totalBonus > bonusOfTheStudentWithMostAttendedLectures)
                {
                    bonusOfTheStudentWithMostAttendedLectures = totalBonus;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(bonusOfTheStudentWithMostAttendedLectures)}.");
            Console.WriteLine($"The student has attended {studentWithMostAttendedLectures} lectures.");
        }
    }
}
