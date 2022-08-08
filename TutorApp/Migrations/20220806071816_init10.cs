using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable   

namespace TutorApp.Migrations
{
    public partial class init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Keyword_Text",
                table: "Keywords",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Keywords_Keyword_Text",
                table: "Keywords",
                column: "Keyword_Text",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Keywords_Keyword_Text",
                table: "Keywords");

            migrationBuilder.AlterColumn<string>(
                name: "Keyword_Text",
                table: "Keywords",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
