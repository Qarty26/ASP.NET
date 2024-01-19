using AutoMapper;
using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Helpers
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();

            CreateMap<User, UserCreateDTO>();
            CreateMap<UserCreateDTO, User>();

            CreateMap<User, UserUpdateDTO>();
            CreateMap<UserUpdateDTO, User>();

            CreateMap<Track, TrackDTO>()
                .ForMember(t => t.Map, opt => opt.MapFrom(src => new MapDTO
                {
                    StartLatitude = src.Map.StartLatitude,
                    StartLongitude = src.Map.StartLongitude,
                    EndLatitude = src.Map.EndLatitude,
                    EndLongitude = src.Map.EndLongitude
                }));
            CreateMap<TrackDTO, Track>();

            CreateMap<Track, TrackCreateDTO>();
            CreateMap<TrackCreateDTO, Track>();

            CreateMap<Car, CarDTO>();
            CreateMap<CarDTO, Car>();

            CreateMap<Car, CarCreateDTO>();
            CreateMap<CarCreateDTO, Car>();

            CreateMap<Hashtag, HashtagDTO>();
            CreateMap<HashtagDTO, Hashtag>();

            CreateMap<Hashtag, HashtagCreateDTO>();
            CreateMap<HashtagCreateDTO, Hashtag>();
        }
    }
}
