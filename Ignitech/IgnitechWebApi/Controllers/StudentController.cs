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


        [HttpGet("{teacherCode}")]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetStudents(Guid teacherCode)
        {
            var students = await _studentService.GetStudents(teacherCode);

            return Ok(students);
        }


    }
}

