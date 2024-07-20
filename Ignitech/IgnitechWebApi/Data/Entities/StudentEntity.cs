using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IgnitechWebApi.Data.Entities
{
    public class StudentEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Guid StudentCode { get; set; }

        public virtual ICollection<SubjectEntity>? Subjects { get; set; }

        public int TeacherId { get; set; }
        public virtual TeacherEntity? Teacher { get; set; }

        public StudentEntity()
        {
            StudentCode = Guid.NewGuid();
        }
    }

    public class StudentEntityConfigurationBuilder : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.StudentCode).IsRequired();
            builder.HasOne(x => x.Teacher)
                .WithMany(t => t.Students)
                .HasForeignKey(x => x.TeacherId);

            // Seed data
            builder.HasData(
                new StudentEntity
                {
                    Id = -1,
                    FirstName = "John",
                    LastName = "Doe",
                    TeacherId = -1,
                    StudentCode = Guid.NewGuid()
                },
                new StudentEntity
                {
                    Id = -2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    TeacherId = -1,
                    StudentCode = Guid.NewGuid()
                }
            );
        }
    }
}
