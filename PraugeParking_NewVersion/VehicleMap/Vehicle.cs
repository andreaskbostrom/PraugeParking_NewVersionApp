using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraugeParking_NewVersion.VehicleMap
{
    public abstract class Vehicle : IVehicle
    {
        public string RegNr { get; set; }
        public DateTime DateTime { get; set; }
        public string raw = "hejsan svejsan";
        
        public Vehicle() { }
        public Vehicle( string regNr, DateTime dateTime)
        {
            this.RegNr = regNr;
            this.DateTime = dateTime;

        }

    }
}
