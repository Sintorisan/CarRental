namespace CarRental.Common.Interfaces;

public interface ICustomer
{
    int CustomerId { get; init; }
    long SocialSecurityNumber { get; init; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string FullName { get; set; }
    IRentalVehicle? RentedVehicle { get; set; }
}
