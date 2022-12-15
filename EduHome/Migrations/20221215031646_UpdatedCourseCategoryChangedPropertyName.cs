using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedCourseCategoryChangedPropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseCategories_Events_EventId",
                table: "CourseCategories");

            migrationBuilder.DropIndex(
                name: "IX_CourseCategories_EventId",
                table: "CourseCategories");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "CourseCategories");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "CourseCategories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourseCategories_CourseId",
                table: "CourseCategories",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseCategories_Courses_CourseId",
                table: "CourseCategories",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseCategories_Courses_CourseId",
                table: "CourseCategories");

            migrationBuilder.DropIndex(
                name: "IX_CourseCategories_CourseId",
                table: "CourseCategories");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "CourseCategories");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "CourseCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourseCategories_EventId",
                table: "CourseCategories",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseCategories_Events_EventId",
                table: "CourseCategories",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
