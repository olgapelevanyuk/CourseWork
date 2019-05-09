using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using CityDTO = OlympicFlights.DataAccess.CityManagement.City;

namespace OlympicFlights.Service.CityManagement
{
    public class CityMappingProfile : Profile
    {
        public CityMappingProfile()
        {
            CreateMap<UpdateCityRequest, CityDTO>()
                .ForMember(db => db.CountryId, opt => opt.MapFrom(req => req.CountryId))
                .ForMember(db => db.CityName, opt => opt.MapFrom(req => req.CityName))
                .ForMember(db => db.Created, opt => opt.MapFrom(req => DateTime.UtcNow))
                .ForMember(db => db.Updated, opt => opt.MapFrom(req => DateTime.UtcNow))
                .ForMember(db => db.IsDeleted, opt => opt.MapFrom(req => req.IsDeleted))
                .ForAllOtherMembers(opts => opts.Ignore());

            CreateMap<CityDTO, City>()
                .ForMember(bll => bll.CityId, opt => opt.MapFrom(db => db.CityId))
                .ForMember(bll => bll.CityName, opt => opt.MapFrom(db => db.CityName))
                .ForMember(bll => bll.CountryId, opt => opt.MapFrom(db => db.CountryId))
                .ForMember(bll => bll.IsDeleted, opt => opt.MapFrom(db => db.IsDeleted));
        }

    }
}
