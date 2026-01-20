using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    internal class Student
    {
        public string Name;
        public int Age;
        public double GPA;

        public Student()
        {
            Name = "Unbekannt";
            Age = 0;
            GPA = 0;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying.");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, age: {Age}, GPA: {GPA}");
        }
    }
}
