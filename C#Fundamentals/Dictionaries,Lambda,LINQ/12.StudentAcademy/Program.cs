using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            string studentName = "";
            double studentGrade = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                studentName = Console.ReadLine();
                studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                    students[studentName].Add(studentGrade);
                }
                else
                {
                    students[studentName].Add(studentGrade);
                }
            }

            Dictionary<string, double> passedStudents = new Dictionary<string, double>();

            foreach (var student in students)
            {
                List<double> studentGrades = students[student.Key];
                double averageStudentGrade = studentGrades.Average();

                if (averageStudentGrade >= 4.50)
                {
                    if (!passedStudents.ContainsKey(student.Key))
                    {
                        passedStudents.Add(student.Key, averageStudentGrade);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            passedStudents = passedStudents.OrderByDescending(student => student.Value).ToDictionary(x => x.Key, y => y.Value);

            foreach (var student in passedStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
