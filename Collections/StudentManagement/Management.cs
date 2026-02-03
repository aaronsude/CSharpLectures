using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.StudentManagement
{
    public class StudentManagement
    {
        private List<Student> students = new List<Student>();

        public void Start()
        {
            bool running = true;

            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        RemoveStudent();
                        break;
                    case "3":
                        DisplayAllStudents();
                        break;
                    case "4":
                        SearchByName();
                        break;
                    case "5":
                        DisplayGPARanking();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Program terminated.");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("===== STUDENT MANAGEMENT SYSTEM =====");
            Console.WriteLine();
            Console.WriteLine("Student Administration:");
            Console.WriteLine("────────────────────────");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Remove student");
            Console.WriteLine("3. Display all students");
            Console.WriteLine("4. Search by name");
            Console.WriteLine("5. GPA ranking");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Menu: ");
        }

        private void AddStudent()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Matriculation number: ");
            string matriculationNumber = Console.ReadLine();

            Console.Write("GPA: ");
            if (double.TryParse(Console.ReadLine(), out double gpa))
            {
                Student newStudent = new Student(name, matriculationNumber, gpa);
                students.Add(newStudent);
                Console.WriteLine($"{name} added");
            }
            else
            {
                Console.WriteLine("Invalid GPA value.");
            }
        }

        private void RemoveStudent()
        {
            Console.Write("Matriculation number of student to remove: ");
            string matriculationNumber = Console.ReadLine();

            Student studentToRemove = students.Find(s => s.MatriculationNumber == matriculationNumber);

            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine($"{studentToRemove.Name} removed");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        private void DisplayAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            Console.WriteLine("──────────────");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        private void SearchByName()
        {
            Console.Write("Name to search: ");
            string searchName = Console.ReadLine().ToLower();

            List<Student> foundStudents = students.FindAll(s =>
                s.Name.ToLower().Contains(searchName));

            if (foundStudents.Count == 0)
            {
                Console.WriteLine("No students found.");
            }
            else
            {
                Console.WriteLine("Found students:");
                Console.WriteLine("──────────────");
                foreach (Student student in foundStudents)
                {
                    Console.WriteLine(student);
                }
            }
        }

        private void DisplayGPARanking()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            List<Student> sortedStudents = students.OrderByDescending(s => s.GPA).ToList();

            Console.WriteLine("GPA Ranking (descending):");
            Console.WriteLine("──────────────");
            int rank = 1;
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine($"{rank}. {student}");
                rank++;
            }
        }
    }
}
