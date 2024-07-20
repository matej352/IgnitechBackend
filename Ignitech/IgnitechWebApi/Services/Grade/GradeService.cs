using AutoMapper;
using IgnitechWebApi.Data;
using IgnitechWebApi.DTOs;
using Microsoft.EntityFrameworkCore;

namespace IgnitechWebApi.Services.Grade
{
    public class GradeService : IGradeService
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GradeService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<double> CalculateAvgGrade(int studentId, int subjectId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GradeDto>> GetGrades(int studentId, int subjectId)
        {
            var grades = await _context.Grades
                .Include(g => g.Subject)
                .Where(g => g.Subject.StudentId == studentId && g.Subject.StudentId == studentId)
                .ToListAsync();

            return _mapper.Map<List<GradeDto>>(grades);
        }
    }
}
