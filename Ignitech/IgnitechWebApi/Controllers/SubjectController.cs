using IgnitechWebApi.DTOs;
using IgnitechWebApi.Services.Student;
using IgnitechWebApi.Services.Subject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IgnitechWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {

        private readonly ISubjectService _subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpGet("{teacherId}")]
        public async Task<ActionResult<CreateStudentDto>> GetTeachersSubjects(int teacherId)
        {
            var subjects = await _subjectService.GetTeachersSubjects(teacherId);

            return Ok(subjects);
        }

        [HttpGet("{studentId}")]
        public async Task<ActionResult<CreateStudentDto>> GetStudentsSubjects(int studentId)
        {
            var subjects = await _subjectService.GetStudentsSubjects(studentId);

            return Ok(subjects);
        }


    }
}
