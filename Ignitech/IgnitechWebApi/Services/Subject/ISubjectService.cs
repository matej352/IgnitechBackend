using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Services.Subject
{
    public interface ISubjectService
    {
        public Task<IEnumerable<SubjectDto>> GetStudentsSubjects(int studentId);
        public Task<IEnumerable<SubjectDto>> GetTeachersSubjects(int teacherId);
    }
}
