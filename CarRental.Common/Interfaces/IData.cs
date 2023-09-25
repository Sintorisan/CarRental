namespace CarRental.Common.Interfaces;

public interface IData
{
    IEnumerable<IRentalVehicle> rentalVehicles();
    IEnumerable<ICustomer> customers();
    IEnumerable<IBooking> bookings();
    void CreateBooking(ICustomer customer, IRentalVehicle vehicle);
}
