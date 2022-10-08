using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraugeParking_NewVersion.VehicleMap
{
    public class Mc : Vehicle 
    {

        public int VehicleSize = 10;

        public Mc() { }
        public Mc(string regNr, DateTime dateTime, int vehicleSize = 10) : base(regNr, dateTime)
        {
            VehicleSize = vehicleSize;
        }

        
    }
}
