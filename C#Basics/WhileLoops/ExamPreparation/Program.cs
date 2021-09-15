using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTotalFails = int.Parse(Console.ReadLine());
            int numberOfFailsTillNow = 0;
            string problemName = "";
            double score = 0;
            int numberOfProblems = 0;
            double averageScore = 0;
            string lastProblemSolved = "";

            while (problemName != "Enough")
            {
                 if (problemName == "Enough" || numberOfFailsTillNow == numberOfTotalFails)
                {
                    break;
                }

                problemName = Console.ReadLine();

                if (problemName == "Enough" || numberOfFailsTillNow == numberOfTotalFails)
                {
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    score += grade;
                    numberOfFailsTillNow++;
                    numberOfProblems++;
                    lastProblemSolved = problemName;
                }
                else if (grade > 4)
                {
                    score += grade;
                    lastProblemSolved = problemName;
                    numberOfProblems++;
                }

            }
            averageScore = score / numberOfProblems;

            if (problemName == "Enough")
            {
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {numberOfProblems}");
                Console.WriteLine($"Last problem: {lastProblemSolved}");
            }
            else
            {
                Console.WriteLine($"You need a break, {numberOfFailsTillNow} poor grades.");
            }
        }
    }
}
