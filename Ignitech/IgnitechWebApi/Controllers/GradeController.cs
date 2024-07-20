using IgnitechWebApi.DTOs;
using IgnitechWebApi.Services.Grade;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IgnitechWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IGradeService _gradeService;

        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }


        // Method 5
        [HttpGet("student/{studentId}/subject/{subjectId}")]
        public async Task<ActionResult<IEnumerable<GradeDto>>> GetGrades(int studentId, int subjectId)
        {
            var grades = await _gradeService.GetGrades(studentId, subjectId);

            return Ok(grades);
        }


        [HttpGet("student/{studentId}/subject/{subjectId}/avg")]
        public async Task<ActionResult<double>> CalculateAvgGrade(int studentId, int subjectId)
        {
            var avgGrade = await _gradeService.CalculateAvgGrade(studentId, subjectId);

            return Ok(avgGrade);
        }

    }
}
