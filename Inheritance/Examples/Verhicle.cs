using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Examples
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int YearOfProduction { get; set; }
        public string Model { get; set; }
        public virtual void Start() => Console.WriteLine($"{Brand} started.");
    }

    public class Car : Vehicle
    {
        public Car(string brand, int yearOfProduction, int doors) : base()
        {
            Brand = brand; YearOfProduction = yearOfProduction; Doors = doors;
        }
        public int Doors { get; set; }
        public void Honk() => Console.WriteLine($"{Brand} honks!");
        public override void Start() => Console.WriteLine($"Car {Brand} started.");
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, int yearOfProduction, int ps) : base()
        {
            Brand = brand; YearOfProduction = yearOfProduction; PS = ps;
        }
        public int PS { get; set; }
        public void Wheelie() => Console.WriteLine($"{Brand} is doing a Wheelie!");
        public override void Start() => Console.WriteLine($"Motorcycle {Brand} started.");
    }

    public class Airplane : Vehicle
    {
        public Airplane(string brand, int yearOfProduction, int passengerSeats) : base()
        {
            Brand = brand; YearOfProduction = yearOfProduction; PassengerSeats = passengerSeats;
        }
        public int PassengerSeats { get; set; }
        public override void Start() => Console.WriteLine($"Airplane {Brand} ready for takeoff.");
    }
}
