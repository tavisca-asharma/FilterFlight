using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.Flights.Contract;

namespace Tavisca.Flight.Core.Filters
{
    public class FlightFilterPipeline : Pipeline<IEnumerable<FlightDetails>>
    { 
        public override IEnumerable<FlightDetails> ProcessFilter(IEnumerable<FlightDetails> request)
        { 
            foreach (var filter in filters)
            {
                request = filter.Filter(request);
            }
            return request;
        }
    }
}
