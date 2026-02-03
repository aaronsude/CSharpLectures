using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    internal class StudentAnalysis
    {

        public static void Start()
        {
            Console.WriteLine("===== STUDENT DATA ANALYSIS =====\n");

            List<Student> students = new List<Student>
            {
                new Student { Name = "Anna", StudentId = 12345, GPA = 3.8 },
                new Student { Name = "Bob", StudentId = 12346, GPA = 3.5 },
                new Student { Name = "Charlie", StudentId = 12347, GPA = 2.8 },
                new Student { Name = "Diana", StudentId = 12348, GPA = 3.9 }
            };

            // All students
            Console.WriteLine("All students:");
            Console.WriteLine("───────────────");
            foreach (var s in students)
                s.PrintInfo();

            // 1. GPA >= 3.5
            Console.WriteLine("\n1. Students with GPA >= 3.5:");
            var highAchievers = students.Where(s => s.GPA >= 3.5);
            foreach (var s in highAchievers)
                Console.WriteLine($"   {s.Name}");

            // 2. Sorted by GPA
            Console.WriteLine("\n2. Sorted by GPA (descending):");
            var sortedByGPA = students.OrderByDescending(s => s.GPA);
            foreach (var s in sortedByGPA)
                s.PrintInfo();

            // 3. Top 2
            Console.WriteLine("\n3. Top 2 students:");
            var top2 = students.OrderByDescending(s => s.GPA).Take(2);
            foreach (var s in top2)
                Console.WriteLine($"   {s.Name}");

            // 4. Average
            Console.WriteLine($"\n4. Average GPA: {students.Average(s => s.GPA):F2}");

            // 5. Best grade
            double maxGPA = students.Max(s => s.GPA);
            Student? topStudent = students.FirstOrDefault(s => s.GPA == maxGPA);
            if (topStudent != null)
            {
                Console.WriteLine($"\n5. Best grade: {maxGPA} ({topStudent.Name})");
            }
        }


        public class Student
        {
            public string Name { get; set; }
            public int StudentId { get; set; }
            public double GPA { get; set; }

            public void PrintInfo()
            {
                Console.WriteLine($"Name: {Name}, ID: {StudentId}, GPA: {GPA}");
            }
        }
    }
}
