using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tavisca.Flight.Core.Interface;
using Tavisca.FlightItinerary;
using Tavisca.Flights.Contract;

namespace Tavisca.Flight.Core.Filters
{
    public class FilterByAirlineCode : IFilter<IEnumerable<FlightDetails>>
    { 
        private string _airliner;
        public FilterByAirlineCode(string filterAirlineParameter)
        {
            _airliner = filterAirlineParameter;
        }
        public IEnumerable<FlightDetails> Filter(IEnumerable<FlightDetails> listOfItineraiesAvailable)
        { 
            if (listOfItineraiesAvailable.Count(flight => flight.AirlineCode == _airliner) > 0)
            {
                listOfItineraiesAvailable = listOfItineraiesAvailable.OrderBy(o => o.AirlineCode).Where(o => o.AirlineCode == _airliner).ToList();
            }
            return listOfItineraiesAvailable;
        }
         
    }
}
