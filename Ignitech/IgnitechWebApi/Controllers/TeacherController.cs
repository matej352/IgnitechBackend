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
    }
}
