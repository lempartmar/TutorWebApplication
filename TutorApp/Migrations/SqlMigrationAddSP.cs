using Microsoft.EntityFrameworkCore.Migrations;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TutorApp.Migrations
{
    public abstract class SqlMigrationAddSP : Migration
    {
        protected sealed override void Up(MigrationBuilder migrationBuilder)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var type = GetType();
            var regex = new Regex($@"{Regex.Escape(type.Namespace)}\.\d{{14}}_{Regex.Escape(type.Name)}\.sql");

            var resourceName = assembly.GetManifestResourceNames().FirstOrDefault(x => regex.IsMatch(x));
            using var stream = assembly.GetManifestResourceStream(resourceName);
            using var reader = new StreamReader(stream);
            var sqlResult = reader.ReadToEnd();
            migrationBuilder.Sql(sqlResult);
        }
    }

}
