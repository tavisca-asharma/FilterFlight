using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.Flights.Contract;

namespace Tavisca.Flight.Core.Interface
{
    public interface IFilter<T>
    {
        T Filter(T input);
    }
}
