using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OlympicFlights.Service.OlympicFlightsServiceExceptions
{
    public class ItemsNotFoundException : Exception
    {
        public ItemsNotFoundException()
        {
        }

        public ItemsNotFoundException(string message) : base(message)
        {
        }

        public ItemsNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ItemsNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
