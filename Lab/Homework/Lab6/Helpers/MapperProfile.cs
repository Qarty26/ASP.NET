using AutoMapper;
using Lab3_2.Models;
using Lab3_2.Models.DTOs;

namespace Lab3_2.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();

            CreateMap<User, UserDTO>()
                .ForMember(ud => ud.FullName, opts => opts.MapFrom(u => u.FirstName + u.LastName));

        }
    }
}
