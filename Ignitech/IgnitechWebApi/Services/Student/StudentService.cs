using AutoMapper;
using IgnitechWebApi.Data;
using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Services.Student
{
    public class StudentService : IStudentService
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public StudentService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<IEnumerable<StudentDto>> GetStudents(Guid teacherCode)
        {
            throw new NotImplementedException();
        }
    }
}
