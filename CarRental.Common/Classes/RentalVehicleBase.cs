using CarRental.Common.Enums;


namespace CarRental.Common.Classes;

public class RentalVehicleBase
{
    public int VehicleId { get; init; }
    public VehicleType VehicleType { get; set; }
    public VehicleFuel VehicleFuel { get; set; }
    public Availability Availability { get; set; } = Availability.Available;

    public RentalVehicleBase(VehicleType vehicleType, VehicleFuel vehicleFuel)
    {
        VehicleType = vehicleType;
        VehicleFuel = vehicleFuel;
        VehicleId = VehicleIdGenerator();
    }

    private int VehicleIdGenerator()
    {
        Random random = new Random();
        return random.Next(0, 1000);
    }
}
