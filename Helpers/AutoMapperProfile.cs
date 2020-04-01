using AutoMapper;
using SimpleApiAuthRegUser.Entities;
using SimpleApiAuthRegUser.Models;

namespace SimpleApiAuthRegUser.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}