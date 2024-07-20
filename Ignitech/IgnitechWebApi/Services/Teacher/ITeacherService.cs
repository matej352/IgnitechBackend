using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Services.Teacher
{
    public interface ITeacherService
    {
        public Task<UserDto> CreateTeacher(CreateUserDto user);
        public Task<UserDto> GetTeacher(int studentId, int subjectId);
        public Task<IEnumerable<UserDto>> GetTeachers();
    }
}
