using AutoMapper;
using IgnitechWebApi.Data;
using IgnitechWebApi.Data.Entities;
using IgnitechWebApi.DTOs;
using Microsoft.EntityFrameworkCore;

namespace IgnitechWebApi.Services.Teacher
{
    public class TeacherService : ITeacherService
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public TeacherService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;


        }
        public async Task<UserDto> CreateTeacher(CreateUserDto user)
        {
            var teacherEntity = _mapper.Map<TeacherEntity>(user);
            _context.Teachers.Add(teacherEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<UserDto>(teacherEntity);
        }

        public async Task<UserDto> GetTeacher(int studentId, int subjectId)
        {
            var subject = await _context.Subjects
                .Include(s => s.Teacher)
              .Where(s => s.StudentId == studentId && s.Id == subjectId)
              .FirstOrDefaultAsync();

            if (subject is not null)
            {
                var teacher = subject.Teacher;
                return _mapper.Map<UserDto>(teacher);
            } else
            {
                return null;
            }
        }

        public async Task<IEnumerable<UserDto>> GetTeachers()
        {
            var teachers = await _context.Teachers.ToListAsync();
            return _mapper.Map<IEnumerable<UserDto>>(teachers);
        }
    }
}
