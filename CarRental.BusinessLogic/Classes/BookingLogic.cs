using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.BusinessLogic.Classes;

public class BookingLogic
{
    private readonly IData _db;

    public BookingLogic(IData db) => _db = db;

    public void CalculateBookingCost(int bookingId, DateTime returnDate)
    {
        var bookingToCalculate = _db.bookings().FirstOrDefault(b => b.BookingId == bookingId);

        if (bookingToCalculate != null)
        {
            bookingToCalculate.CalculateRentalCost(returnDate);
        }
    }

    public void CreateNewBooking(ICustomer customer, IRentalVehicle vehicle)
    {
        _db.CreateBooking(customer, vehicle);
    }

    public void CreateNewCustomer(long ssn, string firstName, string lastName)
    { 
        _db.CreateCustomer(ssn, firstName, lastName);
    }

    public void CreateNewVehicle(VehicleType type, VehicleFuel fuel, string regNo, string make, double odom)
    {
        _db.CreateVehicle(type, fuel, regNo, make, odom);
    }

    public IEnumerable<VehicleFuel> GetVehicleFuel()
    {
        return Enum.GetValues(typeof(VehicleFuel)).Cast<VehicleFuel>();
    }
    public IEnumerable<VehicleType> GetVehicleTypes()
    {
        return Enum.GetValues(typeof(VehicleType)).Cast<VehicleType>();
    }
    public IEnumerable<IRentalVehicle> GetAllRentalVehicles()
    {
        return _db.rentalVehicles();
    }
    public IEnumerable<ICustomer> GetAllCustomers()
    {
        return _db.customers();
    }
    public IEnumerable<IBooking> GetAllBookings()
    {
        return _db.bookings();
    }
}
