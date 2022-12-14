using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedTeacherSkillTableTransferedProgressAndNumberForSkillTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Progress",
                table: "Skills");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "TeacherSkills",
                maxLength: 105,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Progress",
                table: "TeacherSkills",
                maxLength: 105,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "TeacherSkills");

            migrationBuilder.DropColumn(
                name: "Progress",
                table: "TeacherSkills");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Skills",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Progress",
                table: "Skills",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: true);
        }
    }
}
