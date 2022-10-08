using PraugeParking_NewVersion.VehicleMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraugeParking_NewVersion
{
    public class ParkingHouse : IParking
    {
       public List<ParkingWindow> parkingWindows = new List<ParkingWindow>();

        //public ParkingWindows
        public ParkingHouse(int size)
        {
            for (int i = 0; i < size; i++)
            {
                parkingWindows.Add(new ParkingWindow());
            }
        }

        public void TestVehicles()
        {
            DateTime datetime = DateTime.Now;
            parkingWindows[0].vehicle = new Car("abc 123", datetime);
            parkingWindows[1].vehicle = new Mc("hel 666", datetime);
            parkingWindows[2].vehicle = new Car("ful 007", datetime);
            parkingWindows[3].vehicle = new Mc("sex 001", datetime);



        }




        public void CheckoutParkedVehicle()
        {
            throw new NotImplementedException();
        }

        public void FindParking()
        {

            throw new NotImplementedException();
        }

        public void InitializeParkingMap(int amount)
        {

            throw new NotImplementedException();
        }

        public void InitializeParkingMap()
        {
            throw new NotImplementedException();
        }

        public void ParkVehicle(string regiregg, string typitypp)
        {
            if (typitypp == "car")
            {
                var test = new Car(regiregg, DateTime.Now);
                int spot = FindParkingSpot();
               parkingWindows[spot].vehicle = test;


                VehicleLog.SaveAction<Car>(test, spot);
                

            }
            if (typitypp == "mc")
            {
                parkingWindows[FindParkingSpot()].vehicle = new Mc(regiregg, DateTime.Now);

            }
            throw new NotImplementedException();
        }

        private int FindParkingSpot()
        {
            for (int i = 0; i < parkingWindows.Count; i++)
            {
                if (parkingWindows[i].vehicle == null)
                {
                    return i;
                }
            }
            return -1;
        }

        public void PayForParking()
        {
            throw new NotImplementedException();
        }

        public void ParkVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
