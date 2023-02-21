namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentsCount = int.Parse(Console.ReadLine());
            var studentRecord = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < studentsCount; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var student = input[0];
                var grade = input[1];

                if (!studentRecord.ContainsKey(student))
                {
                    studentRecord.Add(student, new List<decimal>());
                }
                studentRecord[student].Add(decimal.Parse(grade));
            }

            foreach (var student in studentRecord)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(' ', student.Value.Select(x => x.ToString("f2")))} (avg: {student.Value.Average().ToString("f2")})");
            }
        }
    }
}