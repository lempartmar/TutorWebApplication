// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TutorApp.DAL;

#nullable disable

namespace TutorApp.Migrations
{
    [DbContext(typeof(DbWebContext))]
    [Migration("20220806071523_init9")]
    partial class init9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TutorApp.Models.Advertisement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfExperience")
                        .HasColumnType("datetime2");

                    b.Property<long>("KeywordId")
                        .HasColumnType("bigint");

                    b.Property<long>("TutorId")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("PrimaryKey_Advertisement");

                    b.ToTable("Advertisement");
                });

            modelBuilder.Entity("TutorApp.Models.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CityName")
                        .IsUnique();

                    b.ToTable("City");
                });

            modelBuilder.Entity("TutorApp.Models.Keyword", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Keyword_Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Keywords");
                });

            modelBuilder.Entity("TutorApp.Models.Tutor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long?>("CityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tutors");
                });

            modelBuilder.Entity("TutorApp.Models.TutorKeyword", b =>
                {
                    b.Property<long>("TutorId")
                        .HasColumnType("bigint");

                    b.Property<long>("KeywordId")
                        .HasColumnType("bigint");

                    b.HasKey("TutorId", "KeywordId");

                    b.HasIndex("KeywordId");

                    b.ToTable("TutorKeyword");
                });

            modelBuilder.Entity("TutorApp.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TutorApp.Models.TutorKeyword", b =>
                {
                    b.HasOne("TutorApp.Models.Tutor", "Tutor")
                        .WithMany("TutorsKeywords")
                        .HasForeignKey("KeywordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TutorApp.Models.Keyword", "Keyword")
                        .WithMany("TutorsKeywords")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Keyword");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("TutorApp.Models.Keyword", b =>
                {
                    b.Navigation("TutorsKeywords");
                });

            modelBuilder.Entity("TutorApp.Models.Tutor", b =>
                {
                    b.Navigation("TutorsKeywords");
                });
#pragma warning restore 612, 618
        }
    }
}
