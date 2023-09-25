using CarRental.Common.Enums;

namespace CarRental.Common.Interfaces;

public interface IRentalVehicle
{
    string Make { get; set; }
    string RegistrationNumber { get; set; }
    int VehicleId { get; init; }
    double CostKm { get; set; }
    int CostDay { get; set; }
    double Odometer { get; set; }
    VehicleType VehicleType { get; set; }
    VehicleFuel VehicleFuel { get; set; }
    Availability Availability { get; set; }
}
