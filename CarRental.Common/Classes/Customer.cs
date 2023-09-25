using CarRental.Common.Interfaces;
using System.Text;

namespace CarRental.Common.Classes;

public class Customer : ICustomer
{
    public int CustomerId { get; init; }
    public long SocialSecurityNumber { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public string? RentedVehicle { get; set; }

    public Customer(long SSN, string firstName, string lastName)
    {
        SocialSecurityNumber = SSN;
        FirstName = firstName;
        LastName = lastName;
        FullName = NameConcat();
        CustomerId = IdGenerator();
    }

    public Customer(long SSN, string firstName, string lastName, IRentalVehicle rentalVehicle)
        : this(SSN, firstName, lastName)
    {
        RentedVehicle = rentalVehicle.RegistrationNumber;
    }

    private string NameConcat() => FirstName + " " + LastName;
  
    private int IdGenerator()
    {
        Random random = new Random();
        return random.Next(10000, 99999);
    }
}
