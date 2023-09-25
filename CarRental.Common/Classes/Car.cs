using CarRental.Common.Interfaces;
using CarRental.Common.Enums;

namespace CarRental.Common.Classes;

public class Car : RentalVehicleBase, IRentalVehicle
{
    public string RegistrationNumber { get; set; }
    public string Make { get; set; }
    public double Odometer { get; set; }
    public double CostKm { get; set; }
    public int CostDay { get; set; }

    public Car(VehicleType vehicleType, VehicleFuel vehicleFuel, int id, string regNo, string make, double odometer)
        : base(vehicleType, vehicleFuel, id)
    {
        RegistrationNumber = regNo;
        Make = make;
        Odometer = odometer;

        //Takes the represented number value from the enum that defines the costs
        CostDay = (int)vehicleType;
        CostKm = (double)vehicleFuel;
    }
}
