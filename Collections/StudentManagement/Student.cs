using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.StudentManagement
{
    class Student
    {
        public string Name { get; set; }
        public string MatriculationNumber { get; set; }
        public double GPA { get; set; }

        public Student(string name, string matriculationNumber, double gpa)
        {
            Name = name;
            MatriculationNumber = matriculationNumber;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"{Name} ({MatriculationNumber}) - GPA: {GPA}";
        }
    }
}
