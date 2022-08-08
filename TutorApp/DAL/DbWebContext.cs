using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using TutorApp.Models;

namespace TutorApp.DAL
{
    public class DbWebContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<TutorKeyword> TutorKeyword {get; set;}
        public DbSet<Advertisement> Advertisement { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbWebContext(DbContextOptions<DbWebContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TutorKeyword>()
                .HasKey(x => new { x.TutorId, x.KeywordId });

            modelBuilder.Entity<TutorKeyword>()
                .HasOne(x => x.Tutor)
                .WithMany(y => y.TutorsKeywords)
                .HasForeignKey(y => y.KeywordId);

            modelBuilder.Entity<TutorKeyword>()
                .HasOne(x => x.Keyword)
                .WithMany(y => y.TutorsKeywords)
                .HasForeignKey(y => y.TutorId);


            modelBuilder.Entity<Advertisement>()
                .HasKey(x => x.Id).HasName("PrimaryKey_Advertisement");

            modelBuilder.Entity<Advertisement>().Property(e => e.Value).HasPrecision(28, 12).IsRequired();

            modelBuilder.Entity<City>()
                .HasIndex(u => u.CityName).IsUnique();

            modelBuilder.Entity<Keyword>()
                .HasIndex(u => u.Keyword_Text).IsUnique();
        }
    }
}
