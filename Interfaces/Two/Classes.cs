using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Two
{
    public class Car : IVehicle
    {
        private string _brand;
        public Car(string brand) => _brand = brand;

        public void Start() => Console.WriteLine($"{_brand}: Starting the engine (IVehicle)");
        public void Stop() => Console.WriteLine($"{_brand}: Stopping the engine.");
        public int GetSpeed() => 120;
    }

    public class Airplane : IVehicle, IFlyable
    {
        private string _brand;
        public Airplane(string brand) => _brand = brand;

        public void Start() => Console.WriteLine($"{_brand}: Starting the jet engines (IVehicle)");
        public void Stop() => Console.WriteLine($"{_brand}: Shutting down engines.");
        public int GetSpeed() => 850;

        public void TakeOff() => Console.WriteLine($"{_brand}: Taking off (IFlyable)");
        public void Land() => Console.WriteLine($"{_brand}: Landing on the runway.");
        public int GetAltitude() => 11000;
    }

    public class Boat : IVehicle, IDivable
    {
        private string _name;
        public Boat(string name) => _name = name;

        public void Start() => Console.WriteLine($"{_name}: Starting the outboard motor (IVehicle)");
        public void Stop() => Console.WriteLine($"{_name}: Motor off.");
        public int GetSpeed() => 35;

        public void Sink() => Console.WriteLine($"{_name}: Submerging (IDivable)");
        public void Ascend() => Console.WriteLine($"{_name}: Surfacing.");
        public int GetDepth() => 150;
    }

    public class Helicopter : IVehicle, IFlyable
    {
        private string _model;
        public Helicopter(string model) => _model = model;

        public void Start() => Console.WriteLine($"{_model}: Rotors spinning up (IVehicle)");
        public void Stop() => Console.WriteLine($"{_model}: Rotors stopping.");
        public int GetSpeed() => 240;

        public void TakeOff() => Console.WriteLine($"{_model}: Taking off vertically (IFlyable)");
        public void Land() => Console.WriteLine($"{_model}: Landing on the helipad.");
        public int GetAltitude() => 2500;
    }

}
