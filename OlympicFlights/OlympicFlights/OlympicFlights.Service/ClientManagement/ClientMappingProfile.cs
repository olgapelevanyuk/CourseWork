using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using ClientDb = OlympicFlights.DataAccess.ClientManagement.Client;

namespace OlympicFlights.Service.ClientManagement
{
    public class ClientMappingProfile : Profile
    {
        public ClientMappingProfile()
        {
            CreateMap<UpdateClientRequest, ClientDb>()
                .ForMember(db => db.UserId, opts => opts.MapFrom(req => req.UserId))
                .ForMember(db => db.ClientFirstname, opts => opts.MapFrom(req => req.ClientFirstname))
                .ForMember(db => db.ClientLastname, opts => opts.MapFrom(req => req.ClientLastname))
                .ForMember(db => db.ClientAddress, opts => opts.MapFrom(req => req.ClientAddress))
                .ForMember(db => db.Created, opts => opts.MapFrom(d => DateTime.UtcNow))
                .ForMember(db => db.Updated, opts => opts.MapFrom(d => DateTime.UtcNow))
                .ForAllOtherMembers(opts => opts.Ignore());


            CreateMap<ClientDb, Client>()
                .ForMember(bll => bll.ClientId, opts => opts.MapFrom(db => db.ClientId))
                .ForMember(bll => bll.ClientFirstname, opts => opts.MapFrom(db => db.ClientFirstname))
                .ForMember(bll => bll.ClientLastname, opts => opts.MapFrom(db => db.ClientLastname))
                .ForMember(bll => bll.ClientAddress, opts => opts.MapFrom(db => db.ClientAddress))
                .ForMember(bll => bll.IsDeleted, opts => opts.MapFrom(db => db.IsDeleted));




        }
    }
}
