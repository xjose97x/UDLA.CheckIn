using AutoMapper;
using UDLA.CheckIn.Data.Entities;
using UDLA.CheckIn.WebApi.DTOs;

namespace UDLA.CheckIn.WebApi.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Professor, ProfessorDto>()
                .ForMember(p => p.GivenName, opt => opt.MapFrom(src => src.Name.GivenName))
                .ForMember(p => p.LastName, opt => opt.MapFrom(src => src.Name.LastName))
                .ReverseMap();
            CreateMap<EntryRecord, EntryRecordDto>().ReverseMap();
            CreateMap<Faculty, FacultyDto>().ReverseMap();
        }
    }
}
