using AutoMapper;
using Mapper.Endpoint.User;
using Mapper.Models.DTOs;
using Mapper.Models.Entities;

namespace Mapper.Models.Proflies
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Transation
            CreateMap<Transation, TransationDTO>();
            
            //User
            CreateMap<User, UserDTO>();
            CreateMap<User, UserRequest>();
            CreateMap<UserRequest, User>();
        }
    }
}
