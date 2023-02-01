using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string courseName = "";
            string studentName = "";
            var coursesAndStudents = new Dictionary<string, List<string>>();

            while (command != "end")
            {
                string[] commandToArray = command.Split(':');
                courseName = commandToArray[0];
                studentName = commandToArray[1];

                if (!coursesAndStudents.ContainsKey(courseName))
                {
                    coursesAndStudents.Add(courseName, new List<string>());
                    coursesAndStudents[courseName].Add(studentName);
                }
                else
                {
                    coursesAndStudents[courseName].Add(studentName);
                }

                command = Console.ReadLine();
            }

            
            foreach (var course in coursesAndStudents.OrderByDescending(course => course.Value.Count))
            {
                Console.WriteLine($"{course.Key.Trim()}: {course.Value.Count}");

                coursesAndStudents[course.Key].Sort();

                for (int i = 0; i < course.Value.Count; i++)
                {
                    Console.WriteLine($"--{course.Value[i]}");
                }
            }
        }
    }
}
