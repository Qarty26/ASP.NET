using Exam.Models;
using Exam.Models.DTO;
using AutoMapper;

namespace Exam.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Event, EventDTO>();
            CreateMap<EventDTO, Event>();

            CreateMap<Participant, ParticipantDTO>();
            CreateMap<ParticipantDTO, Participant>();

            CreateMap<EventParticipantRelation, EventParticipantDTO>();
            CreateMap<EventParticipantDTO, EventParticipantRelation>();
        }

    }
}
