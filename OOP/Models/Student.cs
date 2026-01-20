using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    internal class Student
    {
        // Properties
        public string Name { get; set; }
        public int StudentNumber { get; set; }

        private double _gpa;
        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (value >= 1.0 && value <= 5.0)
                    _gpa = value;
                else
                    Console.WriteLine("Error: GPA has to be between 1.0 and 5.0!");
            }
        }

        // Constructor 1: only name and student number
        public Student(string name, int matrikelNummer)
        {
            Name = name;
            StudentNumber = matrikelNummer;
            GPA = 3.0;  // Standard GPA
        }

        // Constructor 2: With GPA
        public Student(string name, int matrikelNummer, double gpa)
        {
            Name = name;
            StudentNumber = matrikelNummer;
            GPA = gpa;
        }

        public string GetStatus()
        {
            if (GPA >= 1.5)
                return "Very good!";
            else if (GPA >= 2.5)
                return "Good";
            else if (GPA >= 3.5)
                return "Okay";
            else
                return "Bad";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} ({StudentNumber}): GPA {GPA} - Status: {GetStatus()}");
        }
    }
}
