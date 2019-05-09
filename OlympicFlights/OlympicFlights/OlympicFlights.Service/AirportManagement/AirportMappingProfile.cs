using AutoMapper;
using System;
using AirportDb = OlympicFlights.DataAccess.AirportManagement.Airport;

namespace OlympicFlights.Service.AirportManagement
{
    public class AirportMappingProfile : Profile
    {
        public AirportMappingProfile()
        {
            CreateMap<AirportDb, Airport>()
                .ForMember(bll => bll.AirportId, opts => opts.MapFrom(db => db.AirportId))
                .ForMember(bll => bll.AirportName, opts => opts.MapFrom(db => db.AirportName))
                .ForMember(bll => bll.AirportCode, opts => opts.MapFrom(db => db.AirportCode))
                .ForMember(bll => bll.CityId, opts => opts.MapFrom(db => db.CityId))
                .ForMember(bll => bll.IsDeleted, opts => opts.MapFrom(db => db.IsDeleted));

            CreateMap<UpdateAirportRequest, AirportDb>()
                .ForMember(db => db.AirportName, opts => opts.MapFrom(db => db.AirportName))
                .ForMember(db => db.AirportCode, opts => opts.MapFrom(db => db.AirportCode))
                .ForMember(db => db.CityId, opts => opts.MapFrom(db => db.CityId))
                .ForMember(db => db.Created, opts => opts.MapFrom(db => DateTime.UtcNow))
                .ForMember(db => db.Updated, opts => opts.MapFrom(db => DateTime.UtcNow))
                .ForAllOtherMembers(opts => opts.Ignore());



        }
    }
}
