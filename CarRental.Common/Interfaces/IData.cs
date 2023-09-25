using CarRental.Common.Classes;
using CarRental.Common.Enums;

namespace CarRental.Common.Interfaces;

public interface IData
{
    IEnumerable<IRentalVehicle> rentalVehicles();
    IEnumerable<ICustomer> customers();
    IEnumerable<IBooking> bookings();
    void CreateBooking(ICustomer customer, IRentalVehicle vehicle);
    void CreateCustomer(long ssn, string firstName, string lastName);
    void CreateVehicle(VehicleType type, VehicleFuel fuel, string regNo, string make, double odometer);
    

}
