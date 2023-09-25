using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Customer : ICustomer
{
    public int CustomerId { get; init; }
    public long SocialSecurityNumber { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public IRentalVehicle? RentedVehicle { get; set; }

    public Customer(long SSN, string firstName, string lastName, int id)
    {
        SocialSecurityNumber = SSN;
        FirstName = firstName;
        LastName = lastName;
        FullName = NameConcat();
        CustomerId = id;
    }

    public Customer(long SSN, string firstName, string lastName, int id, IRentalVehicle rentalVehicle)
        : this(SSN, firstName, lastName, id)
    {
        RentedVehicle = rentalVehicle;
    }

    private string NameConcat() => FirstName + " " + LastName;
}
