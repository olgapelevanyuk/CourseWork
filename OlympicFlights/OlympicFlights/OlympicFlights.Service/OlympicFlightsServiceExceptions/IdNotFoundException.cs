using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.OlympicFlightsServiceExceptions
{
    public class IdNotFoundException : Exception
    {
        public IdNotFoundException()
        {
        }

        public IdNotFoundException(string message) : base(message)
        {
        }

        public IdNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
