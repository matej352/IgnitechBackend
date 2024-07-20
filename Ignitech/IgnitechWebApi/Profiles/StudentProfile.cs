using AutoMapper;
using IgnitechWebApi.Data.Entities;
using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<CreateStudentDto, StudentEntity>();

            CreateMap<StudentEntity, CreateStudentDto>();

            CreateMap<StudentEntity, UserDto>();

            CreateMap<UserDto, StudentEntity>();
        }
    }
}
