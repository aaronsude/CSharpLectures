using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Demo.Interfaces
{
    public interface IVehicle
    {
        string Brand { get; set; }
        void Start();
        void Stop();
    }
}
