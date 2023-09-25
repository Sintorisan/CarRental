namespace CarRental.Common.Interfaces;

public interface IBooking
{
    int BookingId { get; init; }
    ICustomer Customer { get; set; }
    IRentalVehicle RentedVehicle { get; set; }
    DateTime StartDate { get; }
    DateTime EndDate { get; set; }
    string DisplayEndDate {  get; set; }
    double KmStart { get; init; }
    double KmDriven { get; set; }
    double TotalCost { get; set; }
    string Status { get; }


    void CalculateRentalCost(DateTime returnDate);


    void EndBooking(double kmDriven);
}
