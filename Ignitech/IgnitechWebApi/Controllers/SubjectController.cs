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

        // Method 2
        [HttpGet("fromTeacher/{teacherId}")]
        public async Task<ActionResult<IEnumerable<SubjectDto>>> GetTeachersSubjects(int teacherId)
        {
            var subjects = await _subjectService.GetTeachersSubjects(teacherId);

            return Ok(subjects);
        }

        // Method 3
        [HttpGet("fromStudent/{studentId}")]
        public async Task<ActionResult<IEnumerable<SubjectDto>>> GetStudentsSubjects(int studentId)
        {
            var subjects = await _subjectService.GetStudentsSubjects(studentId);

            return Ok(subjects);
        }


    }
}
