using System;
using System.Collections.Generic;
using System.Linq;
using Tavisca.Flight.Core.Filters;
using Tavisca.FlightItinerary;
using Tavisca.Flights.Contract;
using Tavisca.Flights.Service.Interface;

namespace Tavisca.Flights.Service
{
    public class FlightService : IFlightSearchService
    { 

        public List<FlightDetails> FilterFlights(FilterFlightRequest request)
        {
            FlightFilterPipeline flightPipeline = new FlightFilterPipeline();

            List<FlightDetails> listOfItineraiesAvailable = FlightList.Flights;

            //Register the filters to be executed
            if (request.AirlineCode != null)
                flightPipeline.RegisterFilter(new FilterByAirlineCode(request.AirlineCode));
            if (request.ArrivalAirportCode != null)
                flightPipeline.RegisterFilter(new FilterByArrivalAirportCode(request.ArrivalAirportCode));

            //Start pipeline processing
            return flightPipeline.ProcessFilter(listOfItineraiesAvailable).ToList(); 
        }
    }
}
