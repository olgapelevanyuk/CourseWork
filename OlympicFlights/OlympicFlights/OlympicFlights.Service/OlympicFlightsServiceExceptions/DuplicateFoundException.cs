using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.Service.OlympicFlightsServiceExceptions
{
    public class DuplicateFoundException : Exception
    {
        public DuplicateFoundException()
        {
        }

        public DuplicateFoundException(string message) : base(message)
        {
        }

        public DuplicateFoundException(string message,Exception innerException) : base(message, innerException)
        {
        }
    }
}
