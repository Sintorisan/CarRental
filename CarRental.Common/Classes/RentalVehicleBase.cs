using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class RentalVehicleBase
{
    public int VehicleId { get; init; }
    public VehicleType VehicleType { get; set; }
    public VehicleFuel VehicleFuel { get; set; }
    public Availability Availability { get; set; } = Availability.Available;

    public RentalVehicleBase(VehicleType vehicleType, VehicleFuel vehicleFuel, int id)
    {
        VehicleType = vehicleType;
        VehicleFuel = vehicleFuel;
        VehicleId = id;
    }
}
