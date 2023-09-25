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
