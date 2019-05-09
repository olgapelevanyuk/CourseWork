using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlightDb = OlympicFlights.DataAccess.FlightManagement.Flight;

namespace OlympicFlights.Service.FlightManagement
{
    public class FlightsMappingProfile : Profile
    {
        public FlightsMappingProfile()
        {
            CreateMap<FlightDb, Flight>()
                .ForMember(bll => bll.FlightId, opts => opts.MapFrom(db => db.FlightId))
                .ForMember(bll => bll.DepartureTime, opts => opts.MapFrom(db => db.DepartureTime))
                .ForMember(bll => bll.ArriveTime, opts => opts.MapFrom(db => db.ArriveTime))
                //.ForMember(bll => bll.ArriveAirportId, opts => opts.MapFrom(db => db.Airports.Where(air => air.FlightId == db.FlightId && air.IsArrive).First().AirportId))
                //.ForMember(bll => bll.DepartureAirportId, opts => opts.MapFrom(db => db.Airports.Where(air => air.FlightId == db.FlightId && !air.IsArrive).First().AirportId))
                .ForMember(bll => bll.IsDeleted, opts => opts.MapFrom(db => db.IsDeleted))
                .ForMember(bll => bll.FlightPrice, opts => opts.MapFrom(db => db.FlightPrice))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<UpdateFlightRequest, FlightDb>()
                .ForMember(db => db.DepartureTime, opts => opts.MapFrom(req => DateTime.Parse(req.DepartureTime)))
                .ForMember(db => db.ArriveTime, opts => opts.MapFrom(req => DateTime.Parse(req.ArriveTime)))
                .ForMember(db => db.FlightPrice, opts => opts.MapFrom(req => req.FlightPrice))
                .ForMember(db => db.IsDeleted, opts => opts.MapFrom(req => req.IsDeleted))
                .ForAllOtherMembers( opt => opt.Ignore());
        }
    }
}
