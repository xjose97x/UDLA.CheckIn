using AutoMapper;
using UDLA.CheckIn.Data.Entities;
using UDLA.CheckIn.WebApi.DTOs;

namespace UDLA.CheckIn.WebApi.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Professor, ProfessorDto>().ReverseMap();
            CreateMap<EntryRecord, EntryRecordDto>().ReverseMap();
            CreateMap<Faculty, FacultyDto>().ReverseMap();
        }
    }
}
