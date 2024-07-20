using IgnitechWebApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IgnitechWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<GradeEntity> Grades { get; set; }
        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<SubjectEntity> Subjects { get; set; }
        public DbSet<TeacherEntity> Teachers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
