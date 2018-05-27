using AutoMapper;
using UDLA.CheckIn.Data;
using UDLA.CheckIn.WebApi.Dto;

namespace UDLA.CheckIn.WebApi.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<EntryRecord, EntryRecordDto>().ReverseMap();
            CreateMap<Faculty, FacultyDto>().ReverseMap();
        }
    }
}
