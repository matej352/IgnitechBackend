using IgnitechWebApi.DTOs;
using System.Threading.Tasks;

namespace IgnitechWebApi.Services.Grade
{
    public interface IGradeService
    {
        public Task<double> CalculateAvgGrade(int studentId, int subjectId);
        public Task<IEnumerable<GradeDto>> GetGrades(int studentId, int subjectId);
    }
}
