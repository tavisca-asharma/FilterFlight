using System;
using System.Collections.Generic;
using Tavisca.Flights.Contract;

namespace Tavisca.FlightItinerary
{
    public class FlightList
    {
        public static List<FlightDetails> Flights
        {
            get
            {
                return new List<FlightDetails>();
            }
        } 
    }
}
