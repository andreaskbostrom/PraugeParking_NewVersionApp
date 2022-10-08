using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PraugeParking_NewVersion
{
    internal interface IParking
    {
        void ParkVehicle();
        void FindParking();
        void CheckoutParkedVehicle();
        void PayForParking();

        void TestVehicles(); // we dont have any Db right now in this version.

        void InitializeParkingMap(); //This is where you make the parkingspace

    }
}
