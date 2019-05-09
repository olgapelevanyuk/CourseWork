using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TicketDb = OlympicFlights.DataAccess.TicketManagement.Ticket;

namespace OlympicFlights.Service.TicketManagement
{
    public class TicketMappingProfile : Profile
    {
        public TicketMappingProfile()
        {
            CreateMap<TicketDb, Ticket>();

            CreateMap<UpdateTicketRequest, TicketDb>();
        }
    }
}
