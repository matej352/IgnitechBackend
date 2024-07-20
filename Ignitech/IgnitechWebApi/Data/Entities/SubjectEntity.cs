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
        }
    }
}
