using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerTemplate.Data.Migrations
{
    public partial class author : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectStatusName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "ProjectName",
                table: "Issues",
                newName: "Author");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Issues",
                newName: "ProjectName");

            migrationBuilder.AddColumn<string>(
                name: "ProjectStatusName",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
