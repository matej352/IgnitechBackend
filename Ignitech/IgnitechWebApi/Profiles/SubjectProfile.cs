using AutoMapper;
using IgnitechWebApi.Data.Entities;
using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Profiles
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<SubjectDto, SubjectEntity>();

            CreateMap<SubjectEntity, SubjectDto>()
                .ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Student.FirstName + " " + src.Student.LastName));
        }
    }
}
