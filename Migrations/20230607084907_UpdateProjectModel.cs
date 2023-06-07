using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetCorePortfolio.Migrations
{
    public partial class UpdateProjectModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Project",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Project");
        }
    }
}
