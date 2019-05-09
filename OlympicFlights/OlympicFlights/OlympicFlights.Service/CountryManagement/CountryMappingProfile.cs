using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using CountryDTO = OlympicFlights.DataAccess.CountryManagement.Country;
namespace OlympicFlights.Service.CountryManagement
{
    public class CountryMappingProfile : Profile
    {
        public CountryMappingProfile()
        {
            CreateMap<CountryDTO, Country>()
                .ForMember(bll => bll.CountryId, map => map.MapFrom(db => db.CountryId))
                .ForMember(bll => bll.CountryName, map => map.MapFrom(db => db.CountryName))
                .ForMember(bll => bll.IsDeleted, map => map.MapFrom(db => db.IsDeleted));

            CreateMap<UpdateCountryRequest, CountryDTO>()
                .ForMember(db => db.CountryName, map => map.MapFrom(req => req.CountryName))
                .ForMember(db => db.Created, map => map.MapFrom(def => DateTime.UtcNow))
                .ForMember(db => db.Updated, map => map.MapFrom(def => DateTime.UtcNow))
                .ForMember(db => db.IsDeleted, map => map.MapFrom(req => req.IsDeleted))
                .ForAllOtherMembers(opts => opts.Ignore());
        }
    }
}
