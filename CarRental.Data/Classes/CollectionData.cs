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
        _customer.Add(new Customer(7804122684, "John", "Doe", CustomerId()));
        _customer.Add(new Customer(8510091983, "Jane", "Doe", CustomerId()));
        _vehicles.Add(new Car(VehicleType.Combi, VehicleFuel.Fuel, VehicleId(), "CBA321", "SAAB", 14000));
        _vehicles.Add(new Car(VehicleType.Sedan, VehicleFuel.Electric, VehicleId(), "FRW743", "Tesla", 2500));
        _vehicles.Add(new Car(VehicleType.Van, VehicleFuel.Fuel, VehicleId(), "GRS583", "Chrysler", 19000));
        _vehicles.Add(new Motorcycle(VehicleType.Motorcycle, VehicleFuel.Fuel, VehicleId(), "JRT457", "Yamaha", 14500));
        _bookings.Add(new Booking(_customer[0], _vehicles[0]));
        _bookings.Add(new Booking(_customer[1], _vehicles[3]));
    }

    public void CreateBooking(ICustomer customer, IRentalVehicle vehicle)
    {
        _bookings.Add(new Booking(customer, vehicle));
    }
    public void CreateCustomer(long ssn, string firstName, string lastName)
    {
        _customer.Add(new Customer(ssn, firstName, lastName, CustomerId()));
    }
    public void CreateVehicle(VehicleType type, VehicleFuel fuel, string regNo, string make, double odometer)
    {
        switch (type) 
        {
            case VehicleType.Sedan:
                new Car(type, fuel, VehicleId(), regNo, make, odometer);
                break;

            case VehicleType.Van:
                new Car(type, fuel, VehicleId(), regNo, make, odometer);
                break;

            case VehicleType.Combi:
                new Car(type, fuel, VehicleId(), regNo, make, odometer);
                break;

            case VehicleType.Motorcycle:
                new Motorcycle(type, fuel, VehicleId(), regNo, make, odometer);
                break;
            
            default: throw new ArgumentException();
        }

    }

    public int VehicleId()
    {
        Random random = new Random();
        int id;
        do
        {
            id = random.Next(1000, 9999);
        } while (_vehicles.Any(c => c.VehicleId == id));

        return id;
    }
    public int CustomerId()
    {
        Random random = new Random();
        int id;
        do
        {
            id = random.Next(100, 999);
        } while (_customer.Any(c => c.CustomerId == id));
        return id;
    }

    public IEnumerable<IRentalVehicle> rentalVehicles() => _vehicles;
    public IEnumerable<ICustomer> customers() => _customer; 
    public IEnumerable<IBooking> bookings() => _bookings;
}
