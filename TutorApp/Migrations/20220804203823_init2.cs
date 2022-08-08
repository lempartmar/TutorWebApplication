using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutorApp.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE MyCustomProcedure2
                                        AS
                                SELECT * FROM dbo.Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE MyCustomProcedure2");
        }
    }
}
