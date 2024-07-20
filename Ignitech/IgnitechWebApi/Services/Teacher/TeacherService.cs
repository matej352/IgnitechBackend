using AutoMapper;
using IgnitechWebApi.Data;
using IgnitechWebApi.Data.Entities;
using IgnitechWebApi.DTOs;

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
    }
}
