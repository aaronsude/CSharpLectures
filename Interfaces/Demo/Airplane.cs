using Interfaces.Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Demo
{
    internal class Airplane : IVehicle, IFly
    {
        public string Brand { get; set; }

        public Airplane(string brand)
        {
            Brand = brand;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} starts the engine and checks for passengers safety!");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} stops the engine.");
        }

        public void Landing()
        {
            Console.WriteLine($"{Brand} prepares for landing");
        }

        public void Takeoff()
        {
            Console.WriteLine($"{Brand} prepares for takeoff");
        }
    }
}
