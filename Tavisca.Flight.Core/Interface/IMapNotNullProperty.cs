using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Flight.Core.Interface
{ 
    interface IMapNotNullProperty
    {
        IEnumerable<FlightDetails> MapFilter(T input);
    }
}
