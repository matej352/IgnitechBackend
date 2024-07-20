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
        }
    }
}
