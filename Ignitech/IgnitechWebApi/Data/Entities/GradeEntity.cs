using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IgnitechWebApi.Data.Entities
{
    public class GradeEntity
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public DateTime CreatedOn { get; set; }

        public int SubjectId { get; set; }
        public virtual SubjectEntity Subject { get; set; }
    }

    public class GradeEntityConfigurationBuilder : IEntityTypeConfiguration<GradeEntity>
    {
        public void Configure(EntityTypeBuilder<GradeEntity> builder)
        {
            builder.ToTable("Grade");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Value).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.HasOne(x => x.Subject)
                .WithMany(s => s.Grades)
                .HasForeignKey(x => x.SubjectId);

            // Seed data
            builder.HasData(
                new GradeEntity
                {
                    Id = -1,
                    Value = 3,
                    CreatedOn = DateTime.UtcNow.AddDays(-2),
                    SubjectId = -1
                },
                new GradeEntity
                {
                    Id = -2,
                    Value = 5,
                    CreatedOn = DateTime.UtcNow.AddDays(-2),
                    SubjectId = -1
                },
                new GradeEntity
                {
                    Id = -3,
                    Value = 2,
                    CreatedOn = DateTime.UtcNow.AddDays(-2),
                    SubjectId = -2
                },
                new GradeEntity
                {
                    Id = -4,
                    Value = 4,
                    CreatedOn = DateTime.UtcNow.AddDays(-1),
                    SubjectId = -2
                },
                new GradeEntity
                {
                    Id = -5,
                    Value = 1,
                    CreatedOn = DateTime.UtcNow.AddDays(-1),
                    SubjectId = -3
                },
                new GradeEntity
                {
                    Id = -6,
                    Value = 5,
                    CreatedOn = DateTime.UtcNow.AddDays(-1),
                    SubjectId = -3
                }
            );
        }
    }
}
