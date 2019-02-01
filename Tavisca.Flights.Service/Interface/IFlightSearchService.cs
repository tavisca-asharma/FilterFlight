using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.Flights.Contract;

namespace Tavisca.Flights.Service.Interface
{
    public interface IFlightSearchService
    {
        List<FlightDetails> FilterFlights(FilterFlightRequest request);
    }
}
