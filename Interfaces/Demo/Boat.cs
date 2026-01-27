using Interfaces.Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Demo
{
    internal class Boat : IVehicle
    {
        public string Brand { get; set; }

        public Boat(string brand)
        {
            Brand = brand;
        }
        public void Start()
        {
            Console.WriteLine($"Boat ready for water");
        }

        public void Stop()
        {
            Console.WriteLine($"Boat out of water");
        }
    }
}
