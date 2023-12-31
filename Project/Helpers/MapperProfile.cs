﻿using AutoMapper;
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

            CreateMap<Track, TrackDTO>();
            CreateMap<TrackDTO, Track>();

            CreateMap<Car, CarDTO>();
            CreateMap<CarDTO, Car>();

            CreateMap<Hashtag, HashtagDTO>();
            CreateMap<HashtagDTO, Hashtag>();
        }
    }
}
