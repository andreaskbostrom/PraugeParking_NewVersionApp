using PraugeParking_NewVersion.VehicleMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PraugeParking_NewVersion
{
    static class VehicleLog
    {
        //public static void SaveToTextFile<T>(List<T> data, string filePath) where T : class
        public static void SaveAction<T>(T VehicleAction, int spot) where T : Vehicle
        {
            //List<string> lines = new List<string>();
            StringBuilder line = new StringBuilder();


            var cols = VehicleAction.GetType().GetProperties();

            foreach (var col in cols)
            {
                line.Append(col.Name);
                line.Append(",");
            }

            string filePath = @"C:\Users\andre\source\repos\BUVObjektorgenteradProg\DemoDemo\PraugeParking_NewVersionApp\PraugeParking_NewVersion\history.txt";
            System.IO.File.WriteAllLines(filePath, line.ToString());
        }



    }
}
