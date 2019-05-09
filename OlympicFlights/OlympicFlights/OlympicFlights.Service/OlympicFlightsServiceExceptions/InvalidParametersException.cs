using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OlympicFlights.Service.OlympicFlightsServiceExceptions
{
    public class InvalidParametersException : Exception
    {
        public InvalidParametersException()
        {
        }

        public InvalidParametersException(string message) : base(message)
        {
        }

        public InvalidParametersException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
