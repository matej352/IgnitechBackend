using AutoMapper;
using IgnitechWebApi.Data;
using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Services.Subject
{
    public class SubjectService : ISubjectService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public SubjectService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<IEnumerable<SubjectDto>> GetStudentsSubjects(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SubjectDto>> GetTeachersSubjects(int teacherId)
        {
            throw new NotImplementedException();
        }
    }
}
