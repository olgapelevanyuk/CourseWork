using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using ApplicationUserDb = OlympicFlights.DataAccess.UserManagement.ApplicationUser;

namespace OlympicFlights.Service.ApplicationUsersManagement
{
    public class ApplicationUserMappingProfile : Profile
    {
        public ApplicationUserMappingProfile()
        {
            CreateMap<ApplicationUserDb, ApplicationUser>()
                .ForMember(bll => bll.ApplicationUserId, opt => opt.MapFrom(db => db.Id))
                .ForMember(bll => bll.ApplicationUserName, opt => opt.MapFrom(db => db.UserName))
                .ForMember(bll => bll.ApplicationUserEmail, opt => opt.MapFrom(db => db.Email))
                .ForAllOtherMembers(opts => opts.Ignore());

            CreateMap<UpdateApplicationUserRequest, ApplicationUserDb>()
                .ForMember(db => db.Id, opt => opt.MapFrom(req => req.UserId))
                .ForMember(db => db.Email, opt => opt.MapFrom(req => req.UserEmail))
                .ForMember(db => db.UserName, opt => opt.MapFrom(req => req.UserName))
                .ForAllOtherMembers(opts => opts.Ignore());
        }
    }
}
