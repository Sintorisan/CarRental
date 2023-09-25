using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Data.Classes;

public class CollectionData : IData
{
    readonly List<IRentalVehicle> _vehicles = new List<IRentalVehicle>();
    readonly List<ICustomer> _customer = new List<ICustomer>();
    readonly List<IBooking> _bookings = new List<IBooking>();


    public CollectionData() => SeedData();

    public void SeedData()
    {
        _customer.Add(new Customer(7804122684, "John", "Doe"));
        _customer.Add(new Customer(8510091983, "Jane", "Doe"));
        _vehicles.Add(new Car(VehicleType.Combi, VehicleFuel.Fuel, "CBA321", "SAAB", 14000));
        _vehicles.Add(new Car(VehicleType.Sedan, VehicleFuel.Electric, "FRW743", "Tesla", 2500));
        _vehicles.Add(new Car(VehicleType.Van, VehicleFuel.Fuel, "GRS583", "Chrysler", 19000));
        _vehicles.Add(new Motorcycle(VehicleType.Motorcycle, VehicleFuel.Fuel, "JRT457", "Yamaha", 14500));
        _bookings.Add(new Booking(_customer[0], _vehicles[0]));
        _bookings.Add(new Booking(_customer[1], _vehicles[3]));
    }

    public void CreateBooking(ICustomer customer, IRentalVehicle vehicle)
    {
        _bookings.Add(new Booking(customer, vehicle));
    }


    public IEnumerable<IRentalVehicle> rentalVehicles() => _vehicles;
    public IEnumerable<ICustomer> customers() => _customer;
    public IEnumerable<IBooking> bookings() => _bookings;
}
