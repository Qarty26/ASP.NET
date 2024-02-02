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

            CreateMap<User, UserWithCarAndTrackDTO>()
                .ForMember(t => t.Tracks, opt => opt.MapFrom( src => src.UserTrackCarRelations
                .Select(ob => new TrackWithCarDTO()
                {
                    Track = new TrackDTO()
                    {
                        Id = ob.Track.Id,
                        Name = ob.Track.Name,
                        Xp = ob.Track.Xp,
                        Confirmed = ob.Track.Confirmed,
                        Map = null
                    },
                    Car = new CarDTO()
                    {
                        Id = ob.Car.Id,
                        Make = ob.Car.Make,
                        Model = ob.Car.Model,
                        Year = ob.Car.Year,
                        Color = ob.Car.Color

                    }
                })
                
                ));
            CreateMap<UserWithCarAndTrackDTO, User>();

            CreateMap<User, UserCreateDTO>();
            CreateMap<UserCreateDTO, User>();

            CreateMap<User, UserUpdateDTO>();
            CreateMap<UserUpdateDTO, User>();

            CreateMap<User, UserSignUpDTO>();
            CreateMap<UserSignUpDTO, User>();

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

            CreateMap<Track, TrackWithTagsDTO>();
            CreateMap<TrackWithTagsDTO, Track>();

            CreateMap<TrackHashtagRelation, TrackHashtagRelationDTO>();
            CreateMap<TrackHashtagRelationDTO, TrackHashtagRelation>();

            CreateMap<Car, CarDTO>();
            CreateMap<CarDTO, Car>();

            CreateMap<Car, CarCreateDTO>();
            CreateMap<CarCreateDTO, Car>();

            CreateMap<Hashtag, HashtagDTO>();
            CreateMap<HashtagDTO, Hashtag>();

            CreateMap<Hashtag, HashtagCreateDTO>();
            CreateMap<HashtagCreateDTO, Hashtag>();

            CreateMap<UserTrackCarRelation, UserTrackCarRelationDTO>();
            CreateMap<UserTrackCarRelationDTO, UserTrackCarRelation>();
        }
    }
}
