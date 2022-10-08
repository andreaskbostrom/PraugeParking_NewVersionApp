using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraugeParking_NewVersion.VehicleMap
{
    public class Car : Vehicle
    {
        public int VehicleSize;


        public Car(string regNr, DateTime dateTime, int vehicleSize = 20) : base( regNr, dateTime) 
        {
            VehicleSize = vehicleSize;
        }

    }
}
