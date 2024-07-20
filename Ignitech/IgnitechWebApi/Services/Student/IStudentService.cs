using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Services.Student
{
    public interface IStudentService
    {
        public Task<IEnumerable<StudentDto>> GetStudents(Guid teacherCode);
    }
}
