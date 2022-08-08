using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorApp.Models;


namespace TutorApp.DAL.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City", "dbo");
            builder.HasIndex(u => u.CityName).IsUnique();
            builder.HasKey(x => x.Id).HasName("PrimaryKey_CityId");
            builder.Property(x => x.Id).HasColumnName("CityId");
            builder.Property(e => e.Id).IsRequired().ValueGeneratedOnAdd();
            //builder.HasMany(x => x.Tutor).WithOne(x => x.City);
        }
    }
}
