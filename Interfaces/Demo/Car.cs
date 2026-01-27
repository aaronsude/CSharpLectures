using Interfaces.Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Demo
{
    internal class Car : IVehicle
    {
        public string Brand { get; set; }


        public Car(string brand)
        {
            Brand = brand;
        }
        public void Start()
        {
            Console.WriteLine($"{Brand} starts the engine.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} stops the engine.");
        }
    }
}
