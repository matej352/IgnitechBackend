using IgnitechWebApi.DTOs;
using IgnitechWebApi.Services.Student;
using IgnitechWebApi.Services.Teacher;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IgnitechWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpPost]
        public async Task<ActionResult<CreateUserDto>> CreateTeacher(CreateUserDto user)
        {
            var teacher = await _teacherService.CreateTeacher(user);

            return Ok(teacher);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetTeachers()
        {
            var teachers = await _teacherService.GetTeachers();

            return Ok(teachers);
        }

        // Method 4
        [HttpGet("student/{studentId}/subject/{subjectId}")]
        public async Task<ActionResult<UserDto>> GetTeacher(int studentId, int subjectId)
        {
            var teacher = await _teacherService.GetTeacher(studentId, subjectId);

            return Ok(teacher);
        }
    }
}
