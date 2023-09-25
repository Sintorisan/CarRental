using CarRental.Common.Interfaces;
using CarRental.Common.Enums;

namespace CarRental.Common.Classes;

public class Motorcycle : RentalVehicleBase, IRentalVehicle
{
    public string RegistrationNumber { get; set; }
    public string Make { get; set; }
    public double Odometer { get; set; }
    public double CostKm { get; set; }
    public int CostDay { get; set; }
    public Motorcycle(VehicleType vehicleType, VehicleFuel vehicleFuel, string regNo, string make, int odometer)
        : base(vehicleType, vehicleFuel)
    {
        RegistrationNumber = regNo;
        Make = make;
        Odometer = odometer;

        //Takes the represented number value from the enum that defines the costs
        CostDay = (int)vehicleType;
        CostKm = vehicleType != VehicleType.Motorcycle ? (int)vehicleType : 0.5;
    }
}

