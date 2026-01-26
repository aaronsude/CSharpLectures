using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Solutions
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks: Woof!");
        }
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} meows: Meow!");
        }
    }

    public class Bird : Animal
    {
        public Bird(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} chirps: Tweet!");
        }
    }

    public class Elephant : Animal
    {
        public Elephant(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }

}
