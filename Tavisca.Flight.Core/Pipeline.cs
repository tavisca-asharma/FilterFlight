using System;
using System.Collections.Generic;
using Tavisca.Flight.Core.Interface;
using Tavisca.Flights.Contract;

namespace Tavisca.Flight.Core
{
    public abstract class Pipeline<T>
    {
        protected readonly List<IFilter<T>> filters = new List<IFilter<T>>();
  
        public Pipeline<T> RegisterFilter(IFilter<T> filter)
        {
            filters.Add(filter);
            return this;
        } 
        public abstract T ProcessFilter(T input);
    }
}
