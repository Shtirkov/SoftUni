using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] data = Console.ReadLine().Split();
                string student = data[0];
                decimal grade = decimal.Parse(data[1]);

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<decimal>());
                    students[student].Add(grade);
                }
                else
                {
                    students[student].Add(grade);
                }
            }

            foreach (var student in students)
            {
                var name = student.Key;
                var studentGrades = student.Value;
                var average = studentGrades.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:f2} ");
                   // Console.WriteLine($"(avg: {average:f2})");
                }
                Console.Write($"(avg: {average:f2})");
                Console.WriteLine();
            }
        }
    }
}
