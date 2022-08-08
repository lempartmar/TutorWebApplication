using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorApp.Models;

namespace TutorApp.DAL.Configuration

{
    public class KeywordsConfiguration : IEntityTypeConfiguration<Keyword>
    {
        public void Configure(EntityTypeBuilder<Keyword> builder)
        {
            //builder.ToTable("Keywords", "dbo");
            //builder.HasKey(x => x.Id).HasName("PrimaryKey_KeywordId");
            //builder.Property(x => x.Id).HasColumnName("KeywordId");
            //builder.Property(e => e.Id).IsRequired().ValueGeneratedOnAdd();

            //builder.HasOne<Tutor>(c => c.Tutor).WithMany(c => c.Keyword).HasForeignKey(c => c.TutorId);

        }
    }
}
