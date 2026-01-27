using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.One
{
    public abstract class Animal
    {
        public string Name { get; set; }
        protected Animal(string name) => Name = name;

        public abstract void MakeSound();
        public abstract void Feed();
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void MakeSound() => Console.WriteLine($"{Name} says: Woof!");
        public override void Feed() => Console.WriteLine($"{Name} is eating bones.");
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void MakeSound() => Console.WriteLine($"{Name} says: Meow!");
        public override void Feed() => Console.WriteLine($"{Name} is drinking milk.");
    }

    public class Bird : Animal
    {
        public Bird(string name) : base(name) { }
        public override void MakeSound() => Console.WriteLine($"{Name} says: Tweet!");
        public override void Feed() => Console.WriteLine($"{Name} is eating seeds.");
    }
}
