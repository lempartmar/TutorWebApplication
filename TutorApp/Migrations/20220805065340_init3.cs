using Microsoft.EntityFrameworkCore.Migrations;
using System.Reflection;

#nullable disable

namespace TutorApp.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var assembly = Assembly.GetExecutingAssembly();
            System.Diagnostics.Debug.WriteLine("Assembly1:"+ assembly);
            var resourceNames =
                        assembly.GetManifestResourceNames().
                        Where(str => str.EndsWith(".sql"));
            
            foreach (string resourceName in resourceNames)
            {
                System.Diagnostics.Debug.WriteLine("Assembly2: " + resourceName);
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string sql = reader.ReadToEnd();
                    migrationBuilder.Sql(sql);
                }
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE TutorKeywordTable3");
        }
    }
}
