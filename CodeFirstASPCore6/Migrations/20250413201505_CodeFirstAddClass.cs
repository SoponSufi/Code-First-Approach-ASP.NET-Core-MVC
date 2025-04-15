using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstASPCore6.Migrations
{
    public partial class CodeFirstAddClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Standrad",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Standrad",
                table: "Students");
        }
    }
}
