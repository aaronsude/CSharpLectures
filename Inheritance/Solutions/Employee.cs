using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Solutions
{
    public class Employee
    {
        public string Name { get; set; }
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; } = 160;

        public Employee(string name, double hourlyRate)
        {
            Name = name;
            HourlyRate = hourlyRate;
        }

        public virtual double GetSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

    public class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager(string name, double hourlyRate, double bonus)
            : base(name, hourlyRate)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }
    }

    public class Developer : Employee
    {
        public double OvertimeHours { get; set; }

        public Developer(string name, double hourlyRate, double overtimeHours)
            : base(name, hourlyRate)
        {
            OvertimeHours = overtimeHours;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + (OvertimeHours * (HourlyRate * 1.5));
        }
    }

}
