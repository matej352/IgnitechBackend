using AutoMapper;
using IgnitechWebApi.Data.Entities;
using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Profiles
{
    public class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            CreateMap<CreateUserDto, TeacherEntity>();

            CreateMap<TeacherEntity, CreateUserDto>();

            CreateMap<TeacherEntity, UserDto>();

            CreateMap<UserDto, TeacherEntity>();
        }
    }
}
