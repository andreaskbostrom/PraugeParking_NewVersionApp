
using PraugeParking_NewVersion;
using PraugeParking_NewVersion.VehicleMap;

//VehicleLog praugeParkingAction = new VehicleLog();


ParkingHouse parkingHouse = new ParkingHouse(20);

parkingHouse.TestVehicles();

string testReg = "bes 222";
string TypVehicle = "car";


parkingHouse.ParkVehicle(testReg, TypVehicle);
