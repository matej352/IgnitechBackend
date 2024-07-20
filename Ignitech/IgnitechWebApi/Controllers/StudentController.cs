using IgnitechWebApi.DTOs;
using IgnitechWebApi.Services.Student;
using Microsoft.AspNetCore.Mvc;

namespace IgnitechWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public async Task<ActionResult<CreateStudentDto>> CreateStudent(CreateStudentDto student)
        {
            var createdStudent = await _studentService.CreateStudent(student);

            return Ok(createdStudent);
        }


        // Method 1
        [HttpGet("{teacherId}")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetStudents(int teacherId)
        {
            var students = await _studentService.GetStudents(teacherId);

            return Ok(students);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetStudents()
        {
            var students = await _studentService.GetStudents();

            return Ok(students);
        }


    }
}

