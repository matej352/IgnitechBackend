using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IgnitechWebApi.Data.Entities
{
    public class TeacherEntity
    {



        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Guid TeacherCode { get; set; }
        public virtual ICollection<StudentEntity>? Students { get; set; }

        public virtual ICollection<SubjectEntity>? Subjects { get; set; }

        public TeacherEntity()
        {
            TeacherCode = Guid.NewGuid();
        }
    }

    public class TeacherEntityConfigurationBuilder : IEntityTypeConfiguration<TeacherEntity>
    {
        public void Configure(EntityTypeBuilder<TeacherEntity> builder)
        {
            builder.ToTable("Teacher");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.TeacherCode).IsRequired();

            // Seed data
            builder.HasData(
                new TeacherEntity
                {
                    Id = -1,
                    FirstName = "Luka",
                    LastName = "Modrić",
                    TeacherCode = Guid.NewGuid()
                },
                new TeacherEntity
                {
                    Id = -2,
                    FirstName = "Joško",
                    LastName = "Gvardiol",
                    TeacherCode = Guid.NewGuid()
                }
            );
        }
    }
}
