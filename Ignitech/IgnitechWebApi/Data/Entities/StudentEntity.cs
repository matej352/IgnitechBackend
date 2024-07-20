using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IgnitechWebApi.Data.Entities
{
    public class StudentEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid StudentCode { get; set; }
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
        }
    }
}
