using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedCourseDetailTitleAddNullableInDetailTitleId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetailTitles_DetailTitles_DetailTitleId",
                table: "CourseDetailTitles");

            migrationBuilder.AlterColumn<int>(
                name: "DetailTitleId",
                table: "CourseDetailTitles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetailTitles_DetailTitles_DetailTitleId",
                table: "CourseDetailTitles",
                column: "DetailTitleId",
                principalTable: "DetailTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetailTitles_DetailTitles_DetailTitleId",
                table: "CourseDetailTitles");

            migrationBuilder.AlterColumn<int>(
                name: "DetailTitleId",
                table: "CourseDetailTitles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetailTitles_DetailTitles_DetailTitleId",
                table: "CourseDetailTitles",
                column: "DetailTitleId",
                principalTable: "DetailTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
