using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorApp.Models;

namespace TutorApp.DAL.Configuration
{
    public class TutorConfiguration : IEntityTypeConfiguration<Tutor>
    {
        public void Configure(EntityTypeBuilder<Tutor> builder)
        {
            //builder.ToTable("Tutor", "dbo");
            //builder.HasKey(x => x.Id).HasName("PrimaryKey_TutorId");
            //builder.HasMany(t => t.Keyword).WithMany(t => t.Tutor).Map(m =>
            //{
            //    m.ToTable("TutorKeywords");
            //    m.MapLeftKey("TutorID");
            //    m.MapRightKey("KeywordID");
            //});

            
            //builder.Property(x => x.Id).HasColumnName("TutorId");
            //builder.Property(e => e.Id).IsRequired().ValueGeneratedOnAdd();
            //builder.HasMany<City>(c => c.City).WithMany(c => c.Tutor).HasForeignKey(c => c.CityId);
            //base.OnModelCreating(builder);
        }
    }
}
