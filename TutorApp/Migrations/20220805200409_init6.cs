using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutorApp.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Keyword");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutor",
                table: "Tutor");

            migrationBuilder.RenameTable(
                name: "Tutor",
                newName: "Tutors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutors",
                table: "Tutors",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Keyword_Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TutorKeyword",
                columns: table => new
                {
                    TutorId = table.Column<long>(type: "bigint", nullable: false),
                    KeywordId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutorKeyword", x => new { x.TutorId, x.KeywordId });
                    table.ForeignKey(
                        name: "FK_TutorKeyword_Keywords_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Keywords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TutorKeyword_Tutors_KeywordId",
                        column: x => x.KeywordId,
                        principalTable: "Tutors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TutorKeyword_KeywordId",
                table: "TutorKeyword",
                column: "KeywordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TutorKeyword");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutors",
                table: "Tutors");

            migrationBuilder.RenameTable(
                name: "Tutors",
                newName: "Tutor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutor",
                table: "Tutor",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Keyword",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TutorId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyword", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Keyword_Tutor_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Keyword_TutorId",
                table: "Keyword",
                column: "TutorId");
        }
    }
}
