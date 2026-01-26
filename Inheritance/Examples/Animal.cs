using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Examples
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Info()
        {
            Console.WriteLine($"{Name} is {Age} years old.");
        }

        public abstract void MakeSound();

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks: Woof woof!");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} likes chicken");
        }
    }
}
