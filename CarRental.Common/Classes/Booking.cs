using CarRental.Common.Interfaces;
using CarRental.Common.Enums;

namespace CarRental.Common.Classes
{
    public class Booking : IBooking
    {

        public int BookingId { get; init; }
        public ICustomer Customer { get; set; }
        public IRentalVehicle RentedVehicle { get; set; }
        public DateTime StartDate => DateTime.Today;
        public DateTime EndDate { get; set; }
        public string DisplayEndDate { get; set; }
        public double KmStart { get ; init; }
        public double KmDriven { get; set; }
        public double TotalCost { get; set; }
        public string Status => RentedVehicle.Availability == Availability.Booked ? "Open" : "Closed";

        

        public Booking(ICustomer customer, IRentalVehicle vehicle)
        {
            Customer = customer;
            RentedVehicle = vehicle;
            BookingId = BookingIdGenerator();
            KmStart = vehicle.Odometer;

            Customer.RentedVehicle = vehicle.RegistrationNumber;
            RentedVehicle.Availability = Availability.Booked;
        }

        public void CalculateRentalCost(DateTime returnDate)
        {
            TimeSpan rentalDuration = returnDate - StartDate;

            int rentalDurationCost = RentedVehicle.CostDay + (int)rentalDuration.TotalDays * RentedVehicle.CostDay;
            double rentalKmCost = KmDriven * RentedVehicle.CostKm;
            double totalCost = rentalDurationCost + rentalKmCost;

            EndDate = returnDate;
            DisplayEndDate = returnDate.ToShortDateString();
            TotalCost = totalCost;
            KmDriven = KmDriven;

            EndBooking(KmDriven);
        }

        public void EndBooking(double kmDriven)
        {
            Customer.RentedVehicle = default;
            RentedVehicle.Availability = Availability.Available;
            RentedVehicle.Odometer += kmDriven;
        }

        private int BookingIdGenerator()
        {
            Random random = new Random();
            int bookingId = random.Next(1000, 9999) + Customer.CustomerId;
            return bookingId;
        }
    }
}
