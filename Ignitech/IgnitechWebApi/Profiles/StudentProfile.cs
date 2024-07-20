using AutoMapper;
using IgnitechWebApi.Data.Entities;
using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentDto, StudentEntity>();

            CreateMap<StudentEntity, StudentDto>();
        }
    }
}
