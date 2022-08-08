using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutorApp.Migrations
{
    public partial class init14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Advertisement",
                type: "decimal(28,12)",
                precision: 28,
                scale: 12,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Advertisement",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,12)",
                oldPrecision: 28,
                oldScale: 12);
        }
    }
}
