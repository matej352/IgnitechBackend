using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Services.Teacher
{
    public interface ITeacherService
    {
        public Task<UserDto> CreateTeacher(CreateUserDto user);
    }
}
