using AutoMapper;
using IgnitechWebApi.Data;
using IgnitechWebApi.DTOs;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<SubjectDto>> GetStudentsSubjects(int studentId)
        {
            var subjects = await _context.Subjects
               .Include(s => s.Student)
               .Where(s => s.StudentId == studentId)
               .ToListAsync();

            return _mapper.Map<List<SubjectDto>>(subjects);
        }

        public async Task<IEnumerable<SubjectDto>> GetTeachersSubjects(int teacherId)
        {
            var subjects = await _context.Subjects
               .Include(s => s.Student)
               .Where(s => s.TeacherId == teacherId)
               .ToListAsync();

            return _mapper.Map<List<SubjectDto>>(subjects);
        }
    }
}
