using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IgnitechWebApi.Data.Entities
{
    public class SubjectEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class SubjectEntityConfigurationBuilder : IEntityTypeConfiguration<SubjectEntity>
    {
        public void Configure(EntityTypeBuilder<SubjectEntity> builder)
        {
            builder.ToTable("Subject");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
