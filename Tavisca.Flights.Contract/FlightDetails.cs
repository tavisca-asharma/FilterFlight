using System;

namespace Tavisca.Flights.Contract
{
    public class FlightDetails
    {
        public string AirlineCode { get; set; } //JetAirways: 9J
        public string DepartureAirportCode { get; set; }
        public string DepartureType { get; set; }
        public string ArrivalAirportCode { get; set; }
        public string ArrivalType { get; set; }
        public string TravelDate { get; set; }
        public string DepartureTime { get; set; }
        public string DurationOfJourney { get; set; }
        public int NumberOfTravellers { get; set; }
        public string CabinType { get; set; }
    }
}
