using System.Security.Cryptography.X509Certificates;

namespace Student_Grading_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating a list and adding students
            List<Student> students = new List<Student>()
            {
                new Student("Alice", 1),
                new Student("Jack", 2),
                new Student("Mike", 3),
                new Student("Jane", 4),
            };

            // Adding grades
            students[0].AddGrade(85);
            students[0].AddGrade(92);
            students[1].AddGrade(95);
            students[1].AddGrade(97);
            students[2].AddGrade(50);
            students[2].AddGrade(65);
            students[3].AddGrade(25);
            students[3].AddGrade(10);

            // sorting the students by average grade
            var sortedStudents = students.OrderByDescending(x => x.CalculateAverageGrade());

            Console.WriteLine("\nSorted students: ");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.PrintOutput());
            }

            // filtering out failed students (average grade below 50)
            var failedStudents = students.Where(x => x.CalculateAverageGrade() < 50);

            Console.WriteLine("\nFailed students: ");
            foreach (var student in failedStudents)
            {
                Console.WriteLine(student.PrintOutput());
            }
        }
    }
}
