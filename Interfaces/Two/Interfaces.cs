using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Two
{
    public interface IVehicle
    {
        void Start();
        void Stop();
        int GetSpeed();
    }

    public interface IFlyable
    {
        void TakeOff();
        void Land();
        int GetAltitude();
    }

    public interface IDivable
    {
        void Sink();
        void Ascend();
        int GetDepth();
    }

}
