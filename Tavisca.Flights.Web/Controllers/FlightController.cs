using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tavisca.Flights.Contract;
using Tavisca.Flights.Service.Interface;

namespace Tavisca.Flights.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightSearchService _flightSearch;
        public FlightController(IFlightSearchService flightSearch)
        {
            _flightSearch = flightSearch;
        }


        [Route("filter_request")]
        [HttpPost]
        public List<FlightDetails> GetFilteredItineraries(FilterFlightRequest request)
        {
            return _flightSearch.FilterFlights(request);
        }

    }
}
