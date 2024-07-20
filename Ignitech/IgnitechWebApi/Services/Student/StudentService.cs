using AutoMapper;
using IgnitechWebApi.Data;
using IgnitechWebApi.Data.Entities;
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

        public async Task<UserDto> CreateStudent(CreateStudentDto student)
        {
            var studentEntity = _mapper.Map<StudentEntity>(student);
            _context.Students.Add(studentEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<UserDto>(studentEntity);
        }

        public Task<IEnumerable<CreateUserDto>> GetStudents(Guid teacherCode)
        {
            throw new NotImplementedException();
        }
    }
}
