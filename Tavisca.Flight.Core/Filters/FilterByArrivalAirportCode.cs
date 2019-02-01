using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tavisca.Flight.Core.Interface;
using Tavisca.Flights.Contract;

namespace Tavisca.Flight.Core.Filters
{
    public class FilterByArrivalAirportCode : IFilter<IEnumerable<FlightDetails>>
    {
        private string _airliner;
        public FilterByArrivalAirportCode(string filterAirlineParameter)
        {
            _airliner = filterAirlineParameter;
        }
        public IEnumerable<FlightDetails> Filter(IEnumerable<FlightDetails> listOfItineraiesAvailable)
        {
            if (listOfItineraiesAvailable.Count(flight => flight.ArrivalAirportCode == _airliner) > 0)
            {
                listOfItineraiesAvailable = listOfItineraiesAvailable.OrderBy(o => o.ArrivalAirportCode).Where(o => o.ArrivalAirportCode == _airliner).ToList();
            }
            return listOfItineraiesAvailable;
        }

    }
}
