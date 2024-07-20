using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IgnitechWebApi.Data.Entities
{
    public class SubjectEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<GradeEntity> Grades { get; set; }

        public int StudentId { get; set; }

        public virtual StudentEntity Student { get; set; }


        public int TeacherId { get; set; }

        public virtual TeacherEntity Teacher { get; set; }

    }

    public class SubjectEntityConfigurationBuilder : IEntityTypeConfiguration<SubjectEntity>
    {
        public void Configure(EntityTypeBuilder<SubjectEntity> builder)
        {
            builder.ToTable("Subject");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.Student)
                .WithMany(s => s.Subjects)
                .HasForeignKey(x => x.StudentId);
            builder.HasOne(x => x.Teacher)
                .WithMany(t => t.Subjects)
                .HasForeignKey(x => x.TeacherId);

            // Seed data
            builder.HasData(
                new SubjectEntity
                {
                    Id = -1,
                    Name = "Matematička analiza 1",
                    StudentId = -1,
                    TeacherId = -1
                },
                new SubjectEntity
                {
                    Id = -2,
                    Name = "Matematička analiza 1",
                    StudentId = -2,
                    TeacherId = -1
                },
                new SubjectEntity
                {
                    Id = -3,
                    Name = "Fizika",
                    StudentId = -1,
                    TeacherId = -1
                },
                new SubjectEntity
                {
                    Id = -4,
                    Name = "Osnove elektrotehnike",
                    StudentId = -2,
                    TeacherId = -1
                },
                new SubjectEntity
                {
                    Id = -5,
                    Name = "Uvod u programiranje",
                    StudentId = -2,
                    TeacherId = -2
                }
            );
        }
    }
}
